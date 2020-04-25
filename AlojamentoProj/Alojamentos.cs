using System;
using System.Collections.Generic;
using System.Linq;

public class Alojamentos {

	private Alojamento alojamento;
	private Gestor gestor;
	private List<Alojamento> alojamentoList;

	public Alojamentos(List<Alojamento> alojamentoList) 
	{
				this.alojamentoList = alojamentoList;	
	}

	public bool AddAlojamento(Alojamento aloj) 
	{
		if (aloj != null)
		{
			alojamentoList.Add(aloj);
				return true;
		}

		return false;
	}

	public bool RemoveAlojamento(string num) 
	{	
		Alojamento itemToRemove = (this.alojamentoList).Single(r => r.Num == num);
		
		if (itemToRemove != null)
			{
				this.alojamentoList.Remove(itemToRemove);
				return true;
			}
		return false;	
	}

	public bool UpdateAlojamento(string num, Reserva reserv) 
	{
		Alojamento updateAlojamento = (this.alojamentoList).Single(r => r.Num == num);
		
		if (updateAlojamento != null)
			{
				updateAlojamento.Reserva = reserv;
				return true;
			}
		return false;
	}

}
