using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


	public class Galinha
	{
		public bool parado;
		private string movimento; 
		private float posicaoInicial;
		private float posicaoFinal;
		private GameObject galinha;

		private Transform t;
		private float eixoX;




		public Galinha (GameObject galinha, float posicaoInicial, float posicaoFinal)
		{
			this.galinha = galinha;
			this.posicaoInicial = posicaoInicial;
			this.posicaoFinal = posicaoFinal;
			this.t = galinha.transform;
			this.parado = false;
			this.movimento = "I";

		}

	public void andarGalinha()
	{
		if (!parado) {
			switch (movimento) {
			case "I":
				andarInicial();
				break;
			case "D":
				andarDireita();
				break;
			case "E":
				andarEsquerda();
				break;
			default:
				break;
			}

			//Destroy (transform.gameObject);

		}
	}
	private void andarInicial()
	{


		eixoX = t.position.x; //posico atual do objeto
		eixoX += (Pergunta.velocidade + (Time.deltaTime));
		Vector3 v3 = new Vector3 (eixoX, t.position.y, t.position.z);
		t.position = v3;
		if (eixoX <= posicaoFinal) {
			parado = true;
		}
	}

	private void andarEsquerda()
	{

		eixoX = t.position.x; //posico atual do objeto
		eixoX += (Pergunta.velocidade + (Time.deltaTime));
		Vector3 v3 = new Vector3 (eixoX, t.position.y, t.position.z);
		t.position = v3;

		if(eixoX <=-200f)
		{
			eixoX = posicaoInicial;
			v3 = new Vector3 (eixoX, t.position.y, t.position.z);
			t.position = v3;
			parado = true;
		}
	}

	private void andarDireita()
	{

		eixoX = t.position.x; //posico atual do objeto
		eixoX += (Pergunta.velocidade*-1 + (Time.deltaTime));
		Vector3 v3 = new Vector3 (eixoX, t.position.y, t.position.z);
		t.position = v3;

		if(eixoX >=300f)
		{
			eixoX = posicaoInicial;
			v3 = new Vector3 (eixoX, t.position.y, t.position.z);
			t.position = v3;
			parado = true;
		}
	}

	public void setMovimento(string movimento)
	{
		this.movimento = movimento;
		parado = false;
	}
}

