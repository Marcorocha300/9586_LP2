using System;
public class Alojamento 
{
	private int id;
	public string num;
	private string tipo;
	private string lotacao;
	private Reserva reserva;
	private Alojamentos alojamentos;

	public Alojamento(string alojamento) 
	{
		this.num = alojamento;
	}
	
	public int Id 
	{
		get{return	id;}	
		set{id = value;}
	}

	public string Num
	{
		get{return	num;}	
		set{num = value;}
	}

	public string Tipo	
	{
		get{return	tipo;}	
		set{tipo = value;}
	}

	public string Lotacao
	{
		get{return	lotacao;}	
		set{lotacao = value;}
	}

	public Reserva Reserva
	{
		get{return	reserva;}	
		set{reserva = value;}
	}

}
