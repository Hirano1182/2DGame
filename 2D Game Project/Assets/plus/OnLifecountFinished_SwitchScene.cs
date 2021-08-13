using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLifecountFinished_SwitchScene : MonoBehaviour
{
    public int lastCount = 0; 
    public string sceneName = "";
	public string showObjectName;   // �\���I�u�W�F�N�g���FInspector�Ŏw��

	GameObject showObject;

	void Start()
    {
		showObject = GameObject.Find(showObjectName);
		showObject.SetActive(false); // ����
	}

	void FixedUpdate(){ 
	  
		if (LifeCounter.life == lastCount){

			showObject.SetActive(true);
			Invoke(nameof(Damage), 3.0f);
			
			
		}
	}
	void Damage()
	{
		SceneManager.LoadScene(sceneName);
		
	}

	void OnDestroy()
	{
		CancelInvoke();
	}
}