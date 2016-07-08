using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Fases : MonoBehaviour {


	public GameObject botao;
	public bool teste;
	public int valor;
	// Use this for initialization
	public Canvas canvas;
    public GameObject EG;
    public GameObject EP1;
    public GameObject EP2;
	public GameObject FASE2ATIVA;
	public GameObject FASE2INATIVA;
	public GameObject FASE2;
	public GameObject F2EG;
	public GameObject F2EP1;
	public GameObject F2EP2;
	public GameObject FASE3ATIVA;
	public GameObject FASE3INATIVA;
	public GameObject F3EG;
	public GameObject F3EP1;
	public GameObject F3EP2;
	public GameObject FASE4ATIVA;
	public GameObject FASE4INATIVA;
	public GameObject F4EG;
	public GameObject F4EP1;
	public GameObject F4EP2;
	public GameObject FASE5ATIVA;
	public GameObject FASE5INATIVA;
	public GameObject F5EG;
	public GameObject F5EP1;
	public GameObject F5EP2;


    void Start()
	{
		int estrelas;

			if (PlayerPrefs.HasKey ("estrelas1")) {
			estrelas = PlayerPrefs.GetInt ("estrelas1");
			//habilita as estrelas da fase 1
            if(estrelas == 1)
            {
                EG.SetActive(false);
                EP1.SetActive(true);
                EP2.SetActive(false);
            }else if (estrelas == 2)
            {
                EG.SetActive(false);
                EP1.SetActive(true);
                EP2.SetActive(true);
            }else if (estrelas == 3)
            {
                EG.SetActive(true);
                EP1.SetActive(true);
                EP2.SetActive(true);
				FASE2ATIVA.SetActive (true);
				FASE2INATIVA.SetActive (false);
            }


        }

		if (PlayerPrefs.HasKey ("estrelas2")) {
			estrelas = PlayerPrefs.GetInt ("estrelas2");
			//habilita as estrelas da fase 1
			if(estrelas == 1)
			{
				F2EG.SetActive(false);
				F2EP1.SetActive(true);
				F2EP2.SetActive(false);
			}else if (estrelas == 2)
			{
				F2EG.SetActive(false);
				F2EP1.SetActive(true);
				F2EP2.SetActive(true);
			}else if (estrelas == 3)
			{
				F2EG.SetActive(true);
				F2EP1.SetActive(true);
				F2EP2.SetActive(true);
				FASE3ATIVA.SetActive (true);
				FASE3INATIVA.SetActive (false);
			}


		}

		if (PlayerPrefs.HasKey ("estrelas3")) {
			estrelas = PlayerPrefs.GetInt ("estrelas3");
			FASE3ATIVA.SetActive (true);
			FASE3INATIVA.SetActive (false);
			//habilita as estrelas da fase 1
			if(estrelas == 1)
			{
				F3EG.SetActive(false);
				F3EP1.SetActive(true);
				F3EP2.SetActive(false);
			}else if (estrelas == 2)
			{
				F3EG.SetActive(false);
				F3EP1.SetActive(true);
				F3EP2.SetActive(true);
			}else if (estrelas == 3)
			{
				F3EG.SetActive(true);
				F3EP1.SetActive(true);
				F3EP2.SetActive(true);
				FASE4ATIVA.SetActive (true);
				FASE4INATIVA.SetActive (false);
			}


		}

		if (PlayerPrefs.HasKey ("estrelas4")) {
			estrelas = PlayerPrefs.GetInt ("estrelas4");
			FASE4ATIVA.SetActive (true);
			FASE4INATIVA.SetActive (false);
			//habilita as estrelas da fase 1
			if(estrelas == 1)
			{
				F4EG.SetActive(false);
				F4EP1.SetActive(true);
				F4EP2.SetActive(false);
			}else if (estrelas == 2)
			{
				F4EG.SetActive(false);
				F4EP1.SetActive(true);
				F4EP2.SetActive(true);
			}else if (estrelas == 3)
			{
				F4EG.SetActive(true);
				F4EP1.SetActive(true);
				F4EP2.SetActive(true);
				FASE5ATIVA.SetActive (true);
				FASE5INATIVA.SetActive (false);
			}


		}

		if (PlayerPrefs.HasKey ("estrelas5")) {
			estrelas = PlayerPrefs.GetInt ("estrelas5");
			FASE5ATIVA.SetActive (true);
			FASE5INATIVA.SetActive (false);
			//habilita as estrelas da fase 1
			if(estrelas == 1)
			{
				F5EG.SetActive(false);
				F5EP1.SetActive(true);
				F5EP2.SetActive(false);
			}else if (estrelas == 2)
			{
				F5EG.SetActive(false);
				F5EP1.SetActive(true);
				F5EP2.SetActive(true);
			}else if (estrelas == 3)
			{
				F5EG.SetActive(true);
				F5EP1.SetActive(true);
				F5EP2.SetActive(true);

			}


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
