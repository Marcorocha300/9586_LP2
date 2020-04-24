using System;
public class Customer : User  {
	private int id;
	private string nome;
	private string address;
	private string phone;
	private string email;

	public string GetNome() {
		return this.nome;
	}
	public void SetNome(ref string nome) {
		this.nome = nome;
	}
	public string GetAddress() {
		return this.address;
	}
	public void SetAddress(ref string address) {
		this.address = address;
	}
	public string GetPhone() {
		return this.phone;
	}
	public void SetPhone(ref string phone) {
		this.phone = phone;
	}
	public string GetEmail() {
		return this.email;
	}
	public void SetEmail(ref string email) {
		this.email = email;
	}
	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public void Registo() {
		throw new System.Exception("Not implemented");
	}
	public void Reservar() {
		throw new System.Exception("Not implemented");
	}
	public void Ver() {
		throw new System.Exception("Not implemented");
	}
	public void Pagamento() {
		throw new System.Exception("Not implemented");
	}
	public void Actualizar() {
		throw new System.Exception("Not implemented");
	}
	public Customer() {
		throw new System.Exception("Not implemented");
	}

	private Payment payment;
	private Reserva reserva;

	private Customers customers;

}
