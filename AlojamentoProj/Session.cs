/*IPCA-LESI_PL
 * 2019_2020
 * LP2 - Trabalho prático
 * Marco Rocha
 * Nº9586
 */


using AlojamentoProj;
using System;
using System.Collections.Generic;
using System.Data;

class Session
{
    public enum ROLE
    {
        GUEST = 0,
        CUSTOMER = 1,
        STAFF = 2,
        ADMIN = 3
    }

    private Int32 id;
    private ROLE role;

	public Session() 
    {
        this.id = 0;
        this.role = ROLE.GUEST;
		//throw new System.Exception("Not implemented");
	}

    public ROLE getRole()
    {
        return this.role;
    }

    public void Login(string username, string password)
    {
        string table = "[Users]";
        List<string> columns = new List<string>();
        columns.Add("*");

        IDictionary<string, Tuple<SqlDbType, string>> filters = new Dictionary<string, Tuple<SqlDbType, string>>();

        string query = DB.SelectBuilderSQL(table, columns, null, null);

        foreach (IDataRecord row in DB.ExecuteSQL(this, DB.TYPE.SELECT, query, null, null))
        {
            if (row != null)
                Console.WriteLine(row["id"]);
        }

        this.role = ROLE.CUSTOMER;
        
        bool validPassword = BCrypt.Net.BCrypt.Verify(password, "selectdb");
        
    }

    public void Logout()
    {
        
    }

    public void Register()
    {
        // Validate User Data

        string hashedPassword = BCrypt.Net.BCrypt.HashPassword("asdsa");
        //Insert in Database

    }

}
