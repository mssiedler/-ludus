using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pontosMoedas : MonoBehaviour {

    GameObject Button_2;
    public Text pontos;
    public Text Valor_1;
    public Text Valor_2;
    public Text Valor_3;
    public int p = 1000;
    public bool compradoE = false;
    public bool compradoD = false;
    public bool compradoS = false;

   
    void OnStart()
    { 
        pontos.text = p.ToString();
        if (compradoE == true)
        {
            Valor_1.text = "Comprado";
        }
        
        if (compradoD == true)
        {
            Valor_2.text = "Comprado";
        }
        
        if (compradoS == true)
        {
            Valor_3.text = "Comprado";
        }

    }

    public void ComprarEspaco()
    {
        if (p >= 100)   
        {
			p = p - 100;
			pontos.text = p.ToString ();
			compradoE = true;
            Valor_1.text = "Comprado";
        }
        else if (compradoE == true)
        {
            Valor_1.text = "Comprado";
        }
    }

    public void ComprarDino()
    {
		if (p >= 200)
        {
			p = p - 200;
			pontos.text = p.ToString ();
			compradoD = true;
            Valor_2.text = "Comprado";
        }
        else if (compradoD == true)
        {
            Valor_2.text = "Comprado";
        }
    }

    public void ComprarSub()
    {
		if (p >= 300)
        {
			p = p - 300;
			pontos.text = p.ToString ();
			compradoS = true;
            Valor_3.text = "Comprado";
        }
        else if (compradoS == true) 
        {
            Valor_3.text = "Comprado";
        }
    }
}
