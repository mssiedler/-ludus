using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Fases : MonoBehaviour {


	public GameObject botao;
	public bool teste;
	public int valor;
	// Use this for initialization
	public Canvas canvas;


	void Start()
	{
		int estrelas;

			if (PlayerPrefs.HasKey ("estrelas1")) {
			estrelas = PlayerPrefs.GetInt ("estrelas1");
			//habilita as estrelas da fase 1
		}

	}


	//usado na escolha das FASES
	public void chamaOperacao(string operacao)
	{

		PlayerPrefs.SetString ("op", operacao);
		comandosBasicos cb = new comandosBasicos();
		cb.carregaCena ("Fase1");
	}



}
