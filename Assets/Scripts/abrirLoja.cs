﻿using UnityEngine;
using System.Collections;

public class abrirLoja : MonoBehaviour {

    
    public GameObject botao;
    public bool teste;
    public int valor;
    // Use this for initialization

    void Start()
    {
        if (PlayerPrefs.HasKey("moedas"))
        {
            valor = (PlayerPrefs.GetInt("moedas"));

        }

        if (valor <= 99)
        {
            teste = false;
            botao.SetActive(false);
        }
        else if (valor >= 100)
        {
            teste = true;
            botao.SetActive(true);
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
