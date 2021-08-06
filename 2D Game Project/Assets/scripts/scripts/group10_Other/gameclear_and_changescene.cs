using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameclear_and_changescene : MonoBehaviour
{
    public string target;
    public string sceneName;
    public int check;

    Vector3 base_pos;

    void Start()
    { // �ŏ��ɍs��
      // �J�����̌��̈ʒu���o���Ă���
        base_pos = Camera.main.gameObject.transform.position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == target)
        {
            check++;
            
            Invoke(nameof(Damage), 3.0f);

        }
    }
	void Damage()
	{
       
        check++;
        SceneManager.LoadScene(sceneName);
        Vector3 pos = this.transform.position;
        Camera.main.gameObject.transform.position = pos;
    }

    void OnDestroy()
    {
        CancelInvoke();
    }
	
		
}

