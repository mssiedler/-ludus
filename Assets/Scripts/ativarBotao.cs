using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ativarBotao : MonoBehaviour {

    public GameObject botaoMUTE;
    public GameObject botaoON;
	public AudioSource audio;    
	public bool tocando = true;



	public void manipulaSom()
	{
		
		if (tocando == false || audio.mute == false)
		{
			botaoMUTE.SetActive (true);
			botaoON.SetActive (false);
			audio.mute = true;
			tocando = true;
		}
		else if (tocando == true || audio.mute == true)
		{
			botaoON.SetActive (true);
			botaoMUTE.SetActive (false);
			audio.mute = false;
			tocando = false;
		}
	}

}

    



