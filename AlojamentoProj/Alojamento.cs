using System;
public class Alojamento {
	private int id;
	private string num;
	private string tipo;
	private string lotacao;

	public Alojamento() {
		throw new System.Exception("Not implemented");
	}
	public int GetId() {
		return this.id;
	}
	public void SetId(ref int id) {
		this.id = id;
	}
	public string GetNum() {
		return this.num;
	}
	public void SetNum(ref string num) {
		this.num = num;
	}
	public string GetTipo() {
		return this.tipo;
	}
	public void SetTipo(ref string tipo) {
		this.tipo = tipo;
	}
	public string GetLotacao() {
		return this.lotacao;
	}
	public void SetLotacao(ref string lotacao) {
		this.lotacao = lotacao;
	}

	private Reserva reserva;
	private Alojamentos alojamentos;

}
