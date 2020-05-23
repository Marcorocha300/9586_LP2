/*IPCA-LESI_PL
 * 2019_2020
 * LP2 - Trabalho prático
 * Marco Rocha
 * Nº9586
 */


using System;
using System.Collections.Generic;

public class Reservas
{
	private Reserva[] reservaList;
	private Reserva reserva;
	private Gestor gestor;

	public Reservas()
	{
		throw new System.Exception("Not implemented");
	}

	public void AddReserva()
	{
		throw new System.Exception("Not implemented");
	}

	public void RemoveReserva()
	{
		throw new System.Exception("Not implemented");
	}

	public void UpdateReserva()
	{
		throw new System.Exception("Not implemented");
	}
}

//	        #region Metodos

//        #region Inserção
//        /// <summary>
//        /// Insere uma vulnerabildade na lista de vulnerabilidades
//        /// </summary>
//        public bool InsereVulnerabilidade(Vulnerabilidade vulnerabilidade)
//        {
//            qtdVulnerabilidades++;
//            vulnerabilidades.Add(vulnerabilidade);
//            return true;
//        }
//        #endregion

//        #region Listagem
//        /// <summary>
//        /// Mostra os dados referentes a uma lista de vulnerabildades
//        /// </summary>
//        public string MostrarDados()
//        {
//            string texto = "";
//            for (int i = 0; i < qtdVulnerabilidades; i++)
//            {
//                texto += "Codigo: " + vulnerabilidades[i].Codigo + "Descrição: " +vulnerabilidades[i].Descricao +
//                    "Nivel de Impacto: "+vulnerabilidades[i].NivelImpacto + "\n\n";

//            }


//            return texto;
//        }

//        #endregion

//        #region Busca
//        /// <summary>
//        /// Procura uma vulnerabilidade numa lista de vulnerabilidades, recebe o id da Vulnerabilidade
//        /// </summary>
//        public int Procura(int id)
//        {
//            throw new System.NotImplementedException();
//        }
//        #endregion

//        #region Edição
//        /// <summary>
//        /// Edita uma vulnerabilidade numa lista de vulnerabilidades, recebe o id da Vulnerabilidade e muda a descrição da vulnerabilidade
//        /// </summary>
//        public bool Editar(int id, string descricao)
//        {
//            // Para fazer na versao 2.0
//            return true;
//        }

//        /// <summary>
//        /// Edita uma vulnerabilidade numa lista de vulnerabilidades, recebe o id da Vulnerabilidade e muda o codigo da vulnerabilidade
//        /// </summary>
//        public bool Editar(int id, int numero)
//        {
//            // Para fazer na versao 2.0
//            return true;
//        }
//         /// <summary>
//        /// Edita uma vulnerabilidade numa lista de vulnerabilidades, recebe o id da Vulnerabilidade e muda a data da vulnerabilidade
//        /// </summary>
//        public bool Editar(int id, DateTime data)
//        {
//            // Para fazer na versao 2.0
//            return true;
//        }

//        /// <summary>
//        /// Edita uma vulnerabilidade numa lista de vulnerabilidades, recebe o id da Vulnerabilidade e muda o estado da vulnerabildade
//        /// </summary>
//        public bool Remove(int id)
//        {
//            // Para fazer na versao 2.0
//            return true;
//        }
//    #endregion
//}}