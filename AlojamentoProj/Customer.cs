using System;
public class Customer : User  
{
	private int id;
	private string nome;
	private string address;
	private string phone;
	private string email;
	private Payment payment;
	private Reserva reserva;
	private Customers customers;
 
	public string Nome 	
	{
		get{return	nome;}	
		set{nome = value;}
	}

	public string Address 		
	{
		get{return	address;}	
		set{address = value;}
	}

	public string Phone 
	{ 		
		get{return	phone;}	
		set{phone = value;}
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

	public bool Registo() 
	{
		throw new System.Exception("Not implemented");
	}

	public bool Reservar() 
	{
		throw new System.Exception("Not implemented");
	}

	public void Ver() 
	{
		throw new System.Exception("Not implemented");
	}

	public void Pagamento() 
	{
		throw new System.Exception("Not implemented");
	}

	public void Actualizar() 
	{
		throw new System.Exception("Not implemented");
	}

	public Customer() 
	{
		//throw new System.Exception("Not implemented");
		this.nome = "Marco";
		this.address = "braga";
	}

}
