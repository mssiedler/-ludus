using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Paineis : MonoBehaviour {

    public GameObject panelOpcoes;
    public GameObject panelAjuda;
    public GameObject panelFigurinha;

    
    public bool telaOpcoesAtiva;
    public bool telaAjudaAtiva;
    public bool telaFigurinhaAtiva;
 


    public void abrirPainel()
    {
        if (telaOpcoesAtiva == false)
        {
            panelOpcoes.SetActive(true);
            telaOpcoesAtiva = true;
        }
        else if (telaOpcoesAtiva == true)
        {
            panelOpcoes.SetActive(false);
            telaOpcoesAtiva = false;

        }
    }

    public void abrirAjuda()
    {
        if (telaAjudaAtiva == false)
        {
            panelOpcoes.SetActive(false);
            panelAjuda.SetActive(true);
            telaAjudaAtiva = true;
            telaOpcoesAtiva = false;
        }
        else if (telaAjudaAtiva == true)
        {
            panelAjuda.SetActive(false);
            telaAjudaAtiva = false;
            

        }

    }
    public void abrirFigurinha()
    {
        if (telaFigurinhaAtiva == false)
        {
            panelOpcoes.SetActive(false);
            panelFigurinha.SetActive(true);
            telaFigurinhaAtiva = true;
            telaOpcoesAtiva = false;
        }
        else if (telaFigurinhaAtiva == true)
        {
            panelFigurinha.SetActive(false);
            telaFigurinhaAtiva = false;

        }

    }


}
