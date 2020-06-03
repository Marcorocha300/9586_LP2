using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlojamentoLocal
{
    class Bungalow
    {
		public string num;
		private string tipo;
		private string lotacao;
		private float custoNoite;

		public Bungalow (string num, string tipo, string lotacao, float custoNoite)
		{
			this.num = num;
			this.tipo = tipo;
			this.lotacao = lotacao;
			this.custoNoite = custoNoite;
		}

		/// <summary>
		/// 
		/// </summary>
		public string Num
		{
			get { return num; }
			set { num = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		public string Lotacao
		{
			get { return lotacao; }
			set { lotacao = value; }
		}


		public float CustoNoite
		{
			get { return custoNoite; }
			set { custoNoite = value; }
		}
	}
}

