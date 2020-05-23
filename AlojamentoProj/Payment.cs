/*IPCA-LESI_PL
 * 2019_2020
 * LP2 - Trabalho prático
 * Marco Rocha
 * Nº9586
 */


using System;

/// <summary>
/// Classe que gere o pagamento
/// </summary>
public class Payment
{
	#region Estado
	private float price;
	private DateTime date;
	private bool estado;
	#endregion

	//private Customer customer;

	public Payment() 
	{
	}
	public Payment(Bungalow price)
	{
		//price paga = new price(); 
	}

	public float Price
	{
		get { return price; }
		set { price = value; }
	}

	public DateTime PaymentDate
	{
		get { return date; }
		set { date = value; }
	}

	public bool PaymentState
	{
		get { return estado; }
		set { estado = value; }
	}

}
