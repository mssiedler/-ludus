using UnityEngine;
using System.Collections;

public class abrirLoja : MonoBehaviour {

    private Moeda din;
    public GameObject botao;
	// Use this for initialization
	void Start () {
        din = FindObjectOfType(typeof(Moeda)) as Moeda;

			
  
	}

    public void desbloquearBotao()
    {
        if (din.dinheiro <= 99)
        {
            botao.SetActive(false);
        }
        else if (din.dinheiro >= 100)
        {
            botao.SetActive(true);
        }
    }

}
