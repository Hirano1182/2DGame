using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLifecountFinished_SwitchScene_plus : MonoBehaviour
{
    public int lastCount = 0; 
    public string sceneName = "";
	public string showObjectName = "";   // �\���I�u�W�F�N�g���FInspector�Ŏw��

	GameObject showObject;

	void Start()
    {
		GameObject.Find("Canvas").transform.Find("RawImage").transform.Find("gameover").gameObject.SetActive(false);

		showObject.SetActive(false); // ����
	}

	void FixedUpdate(){ 
	  
		if (LifeCounter_plus.life == lastCount){

			GameObject.Find("Canvas").transform.Find("RawImage").transform.Find("gameover").gameObject.SetActive(true);
			Invoke(nameof(Damage), 3.0f);
			
			
		}
	}
	void Damage()
	{
		GameObject.Find("Canvas").transform.Find("RawImage").transform.Find("RETRY").gameObject.SetActive(true);
		GameObject.Find("Canvas").transform.Find("RawImage").transform.Find("TYTLE").gameObject.SetActive(true);
		Time.timeScale = 0;
	}

	void OnDestroy()
	{
		CancelInvoke();
	}
}