/*IPCA-LESI_PL
 * 2019_2020
 * LP2 - Trabalho prático
 * Marco Rocha
 * Nº9586
 */

using System;
using System.Dynamic;

public class Customer : User  
{
    #region Estado
    private int id;
	private string nome;
	private string address;
	private string phone;
	private string email;
	private Payment payment;
	private Reserva reserva;
	private Customers customers;
	#endregion

	/// <summary>
	/// Construtor dados vindos do exterior
	/// </summary>
	/// <param name="nome"></param>
	/// <param name="address"></param>
	/// <param name="phone"></param>
	/// <param name="email"></param>
	public Customer(string nome, string address, string phone, string email)
	{
		this.nome = nome;
		this.address = address;
		this.phone = phone;
		this.email = email;
	}

	/// <summary>
	/// Construtor por defeito
	/// </summary>
	public Customer()
	{
		//throw new System.Exception("Not implemented");
		this.nome = "Marco";
		this.address = "braga";
		this.phone = "917833275";
		this.email = "marco@gmail.com";
	}

	/// <summary>
	/// Get e Set Nome
	/// </summary>
	public string Nome 	
	{
		get{return	nome;}	
		set{nome = value;}
	}
	/// <summary>
	/// Get e set Address
	/// </summary>
	public string Address 		
	{
		get{return	address;}	
		set{address = value;}
	}

	public string Phone 
	{ 		
		get{return	phone;}	
		set{ phone = value;}
	}

	public string Email 
	{ 		
		get{return	email;}	
		set{email = value;}
	}
	
	public int Id 
	{ 		
		get{return	id;}	
		set{id = value;}
	}

	public bool Registo(string nome , string address, string passWord, string login ) 
	{
		//throw new System.Exception("Not implemented");
		return true;
	}

	public bool Reservar() 
	{
		throw new System.Exception("Not implemented");
		//Reserva res = new Reserva(customers, checkIn, checkOut, aloj); 
	}

	public void Ver() 
	{
		try
		{
			Ver();
		}
		catch (NotImplementedException notImp)
		{
			Console.WriteLine(notImp.Message);
		}
		throw new System.Exception("Erro");
	}

	public void Pagamento() 
	{
		throw new System.Exception("Not implemented");
	}

	public void Actualizar() 
	{
		throw new System.Exception("Not implemented");
	}
}
