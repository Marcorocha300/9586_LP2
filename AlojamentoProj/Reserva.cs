using System;
public class Reserva {
	private int id;
	private int customerId;
	private string idFuncionario;
	private void dateReserva;
	private void dateCheckin;
	private void dateCheckout;
	private int idAlojamento;
	private float custo;
	private Payment payment;

	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public string GetIdFuncionario() {
		return this.idFuncionario;
	}
	public void SetIdFuncionario(ref string idFuncionario) {
		this.idFuncionario = idFuncionario;
	}
	public void GetDateReserva() {
		return this.dateReserva;
	}
	public void SetDateReserva(ref void dateReserva) {
		this.dateReserva = dateReserva;
	}
	public void GetDateCheckin() {
		return this.dateCheckin;
	}
	public void SetDateCheckin(ref void dateCheckin) {
		this.dateCheckin = dateCheckin;
	}
	public void GetDateCheckout() {
		return this.dateCheckout;
	}
	public void SetDateCheckout(ref void dateCheckout) {
		this.dateCheckout = dateCheckout;
	}
	public int GetIdAlojamento() {
		return this.idAlojamento;
	}
	public void SetIdAlojamento(ref int idAlojamento) {
		this.idAlojamento = idAlojamento;
	}
	public GetCusto() {
		throw new System.Exception("Not implemented");
	}
	public void SetCusto(ref  custo) {
		throw new System.Exception("Not implemented");
	}
	public Reserva() {
		throw new System.Exception("Not implemented");
	}
	public int GetCustumerId() {
		throw new System.Exception("Not implemented");
	}
	public void SetCustumerId(ref int custumerId) {
		throw new System.Exception("Not implemented");
	}

	private Alojamento[] alojamentos;

	private Customer customer;
	private Reservas reservas;

}
