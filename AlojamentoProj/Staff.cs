/*IPCA-LESI_PL
 * 2019_2020
 * LP2 - Trabalho prático
 * Marco Rocha
 * Nº9586
 */


using System;
using System.Collections.Generic;

public class Staff : User  
{
    #region atributos staff
		
		int ident;
		string password;
    
	#endregion

    #region construtor
	public Staff()
	{

	}
	public Staff(int id, string name)
	{
		//base.name = id;
		//base. = password;

	}


	#endregion



	public void ConsultarReservas() 
	{
		throw new System.Exception("Not implemented");
	}

	public void AlterarReservas() 
	{
		throw new System.Exception("Not implemented");
	}
	
	public void Operation() 
	{
		throw new System.Exception("Not implemented");
	}

}
