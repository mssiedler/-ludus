using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Moeda : MonoBehaviour {
	public Text din;

	public int dinheiro;

	void Start () 
	{
		if (PlayerPrefs.HasKey ("moedas")) {
			dinheiro = (PlayerPrefs.GetInt("moedas"));

		}
		this.din.text = "" + this.retornaValor();

	}
		

	public void adicionaValor(int valor)
	{
		this.dinheiro = this.dinheiro + valor;
		this.din.text = "" +this.retornaValor();
	}

	public void retiraValor(int valor)
	{
		dinheiro = dinheiro - valor;
	}

	public int retornaValor()
	{
		return dinheiro;
	}

	public void exibeDin()
	{
		this.din.text = "" + this.retornaValor();
	}
}