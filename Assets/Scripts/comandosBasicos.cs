using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class comandosBasicos : MonoBehaviour {

    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

    public void resetJogo()
    {
        PlayerPrefs.DeleteAll();
    }

    public void abrirSite()
    {
        Application.OpenURL("https://projetoludusifsul.wordpress.com/");
    }


}
