using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class comandosBasicos : MonoBehaviour {
    private Animator controleTela;

    
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

    public void Animation()
    {
        controleTela = GetComponent<Animator>();
        float time;
        
            time = 5;
        

        
            if (time < 0)
            {
            controleTela.SetBool("Normal", time == 0);
        }
            else
            {
                time -= Time.deltaTime;
            }

    }

    public void encerrarAtividade()
    {
        Application.Quit();
    }

    public void abrirArquivo()
    {
        Application.OpenURL("C:/Users/Junior/Documents/GitHub/-ludus/Assets/Resources/Outros/Manual_do_Usuario.pdf");
    }

}
