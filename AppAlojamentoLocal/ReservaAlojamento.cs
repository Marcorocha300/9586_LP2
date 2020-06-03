using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryCustomer;

namespace AppAlojamentoLocal
{
    class ReservaAlojamento
    { 
        Cliente client;
        Alojamento bungalow;
        DateTime resDate;
        DateTime inDate;
        DateTime outDate;
        int days;
        double pay ;
        double price = 100;
   
        public ReservaAlojamento(string UserName, string passWord,string nome, string sobreNome, string address, string phone, string email, DateTime resdate, DateTime checkInDate, DateTime checkOutDate)
        {
            client = new Cliente(UserName, passWord, nome, sobreNome, address, phone, email);
            bungalow = new Alojamento();
            resDate = DateTime.Now;
            inDate = checkInDate;
            outDate = checkOutDate;

        }
        public double Custo(DateTime checkInDate, DateTime checkOutDate)
        {
            this.inDate = checkInDate;
            this.outDate = checkOutDate;
            days = outDate.Day - inDate.Day;
            pay = days*price;

            return pay;
        }
    }
}
