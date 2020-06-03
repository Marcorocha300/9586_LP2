using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryCustomer
{

    public class Cliente
    {
        #region atributos
        private string nome;
        private string sobrenome;
        private string address;
        private string phone;
        private string email;

        #endregion

        #region propriedades
        /// <summary>
        /// Nome cliente
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// sobrenome do cliente
        /// </summary>
        public string Sobrenome 
        { 
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        /// <summary>
        /// Morada do cliente
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// numero de telefone do cliente
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>
        /// Email do cliente
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region métodos
        /// <summary>
        ///  Cria uma nova instância da classe
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public Cliente(string nome, string sobrenome, string address, string phone, string email)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }
        #endregion
    }
}