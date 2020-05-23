/*IPCA-LESI_PL
 * 2019_2020
 * LP2 - Trabalho prático
 * Marco Rocha
 * Nº9586
 */


using System;
using System.Collections.Generic;

public class Reserva 
{	
	#region Estado

	private int id;
	private DateTime dateReserva;
	private DateTime dateCheckin;
	private DateTime dateCheckout;
	private Payment payment;
	private List<Alojamento> alojamentos;
	private Customer customer;

	#endregion

	public int Id
	{
		get{return id;}	
		set{id = value;}
	}

	public DateTime DateReserva
	{
		get{return dateReserva;}	
		set{dateReserva = value;}
	}

	public DateTime DateCheckin 
	{
		get{return dateCheckin;}	
		set{dateCheckin = value;}
	}

	public DateTime DateCheckout 
	{
		get{return dateCheckout;}	
		set{dateCheckout = value;}
	}
	
	
	public  Reserva(Customer customer, DateTime checkIn, DateTime checkOut, Alojamento aloj) 
	{
		this.dateReserva = DateTime.Now;
		this.dateCheckin = checkIn;
		this.dateCheckout = checkOut;
		this.customer = customer;
		this.alojamentos = new List<Alojamento>();
		this.alojamentos.Add(aloj);

	}

}
