using UnityEngine;
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

        if (valor <= 29)
        {
            teste = false;
            botao.SetActive(false);
        }
        else if (valor >= 30)
        {
            teste = true;
            botao.SetActive(true);
        }

    }






}
