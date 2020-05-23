using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AlojamentoProj
{
    class DB
    {
        public enum TYPE
        {
            SELECT,
            INSERT,
            UPDATE,
            DELETE 
        }

        private static string[] cnnString = { "GUEST", "CUSTOMER", "STAFF", "ADMIN" };

        public static string SelectBuilderSQL(string table, List<string> columns, IDictionary<string, Tuple<SqlDbType, string>> filters, IDictionary<string, Tuple<SqlDbType, string>> specials) 
        {
            string query = "SELECT " + columns[0];

            if (columns != null && columns.Count > 1)
                for (int i = 1; i < columns.Count; i++)
                    query += ", " + columns[i];

            query += " FROM " + table;

            int counter = 1;
            if (filters != null && filters.Count > 0){
                query += " WHERE ";

                foreach (string column in filters.Keys)
                {
                    if (counter == filters.Count)
                        query += column + "=@" + counter.ToString();
                    else
                        query += column + "=@" + counter.ToString() + ",";
                    counter++;
                }
            }

            if (specials != null && specials.Count > 0) { 

                foreach (string column in specials.Keys)
                {
                    query += " @" + counter.ToString();
                    counter++;
                }
            }

            return query;
        }

        public static IEnumerable<IDataRecord> ExecuteSQL(Session sess, TYPE type, string query, IDictionary<string, Tuple<SqlDbType, string>> groupA, IDictionary<string, Tuple<SqlDbType, string>> groupB)
        {
            SqlDataReader reader = null;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[cnnString[(int)sess.getRole()]].ConnectionString))
            {
                cnn.Open();

                //SqlCommand s = new SqlCommand(query, cnn);
                SqlCommand s = new SqlCommand("SELECT * FROM [Users]", cnn);
                int counter = 1;
                if (groupA != null && groupA.Count > 0)
                    foreach (Tuple<SqlDbType, string> pair in groupA.Values)
                    {
                        s.Parameters.Add("@" + counter.ToString(), pair.Item1).Value = pair.Item2;
                        counter++;
                    }

                if (groupB != null && groupB.Count > 0)
                    foreach (Tuple<SqlDbType, string> pair in groupB.Values)
                    {
                        s.Parameters.Add("@" + counter.ToString(), pair.Item1).Value = pair.Item2;
                        counter++;
                    }

                s.Prepare();

                if (type == TYPE.SELECT)
                {
                    reader = s.ExecuteReader();
                    if (reader != null && reader.HasRows)
                    {
                        while (reader.Read())
                            yield return reader;
                    }
                    else
                        yield return null;
                    reader.Close();
                }
                else
                    yield return null;
            }
        }
    }
}