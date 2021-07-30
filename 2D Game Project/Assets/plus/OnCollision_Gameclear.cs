using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���؂�ւ��ɕK�v


public class OnCollision_Gameclear : MonoBehaviour
{
	public string keyobject; // ���v���n�u�FInspector�Ŏw��
	public string goalobject;
	public string sceneName;


	bool haveFlag = false;
	

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == keyobject)
		{
			haveFlag = true;
		}
	}
	void OnCollisionStay2D(Collision2D collision)
    {
		if (collision.gameObject.name == goalobject  && haveFlag == true && Input.GetKey(KeyCode.A))
        {
			haveFlag = false;
			SceneManager.LoadScene(sceneName);
		}

	}
		
}
