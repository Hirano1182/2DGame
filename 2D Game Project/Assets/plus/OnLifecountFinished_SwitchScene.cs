using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLifecountFinished_SwitchScene : MonoBehaviour
{
    public int lastCount = 0; 
    public string sceneName = ""; 

	void FixedUpdate(){ 
	  
		if (LifeCounter.life == lastCount){
			
			SceneManager.LoadScene(sceneName);
		}
	}
}