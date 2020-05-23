/*IPCA-LESI_PL
 * 2019_2020
 * LP2 - Trabalho prático
 * Marco Rocha
 * Nº9586
 */



using System;
using System.Collections.Generic;

public class Bungalow : Alojamento  
{
	
	private int id;
	private string name;
	private float price;

	//protected Bungalow  { get; set; }

	public Bungalow (string alojamento ): base(alojamento) 
	{

	}

    #region Metodos
    /// <summary>
    /// Override do to string para mostrar apenas um equipamento
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        string txt = "";
        txt += "Id: " + id +
               "\nNome do Alojamento: " + name +
               "\nPreço por Noite: " + price.ToString() + "\n";
        return txt;

    }

    #endregion

}
