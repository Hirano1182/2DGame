using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameclear_and_stop_changescene : MonoBehaviour
{
    public string target;
    public string sceneName;
    public string targetobjectname1;
    public string targetobjectname3;
    public string targetobjectname4;
    public int check;
    GameObject gameObject1; 
    GameObject gameObject3;
    GameObject gameObject4;


    Vector3 base_pos;

    void Start()
    {
        gameObject1 = GameObject.Find(targetobjectname1);
        gameObject3 = GameObject.Find(targetobjectname3);
        gameObject4 = GameObject.Find(targetobjectname4);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == target)
        {
            check++;
            gameObject1.GetComponent<Forever_MoveH>().enabled = false;
            gameObject3.GetComponent<Forever_MoveH>().enabled = false;
            gameObject4.GetComponent<OnKeyPress_MoveGravityPlus>().enabled = false;
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

