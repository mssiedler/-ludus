using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneSplash : MonoBehaviour {


	float time;
	void Start(){
		time = 3;
	}

	void Update(){
		if (time < 0) {
			comandosBasicos c = new comandosBasicos ();
			c.carregaCena ("Home");
		} else {
			time -= Time.deltaTime;
		}
	
	}

}
