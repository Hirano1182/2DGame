using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyouseisukuroruassi : MonoBehaviour
{
    public string targetobjectname1;
    public string targetobjectname2;
    public string targetobjectname3;
    public string targetobjectname4;

    public bool a = false;
    public bool b = false;

    GameObject gameObject1;
    GameObject gameObject3;
    GameObject gameObject4;

    void Start()
    {
        gameObject1 = GameObject.Find(targetobjectname1);
        gameObject3 = GameObject.Find(targetobjectname3);
        gameObject4 = GameObject.Find(targetobjectname4);

    }

    void FixedUpdate()
    {
        if(a == true && b == true)
        {
            gameObject1.GetComponent<Forever_MoveH>().enabled = false;
            gameObject3.GetComponent<Forever_MoveH>().enabled = false;
            gameObject4.GetComponent<OnKeyPress_MoveGravityPlus>().enabled = false;
            GameObject.Find("Canvas").transform.Find("gameover").gameObject.SetActive(true);
            Invoke(nameof(Damage), 3.0f);
        }
    }

    void Damage()
    {

        GameObject.Find("Canvas").transform.Find("RETRY").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("TYTLE").gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    void OnDestroy()
    {
        CancelInvoke();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetobjectname1)
        {
            a = true;
        }
        if (collision.gameObject.name == targetobjectname2)
        {
            b = true;
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetobjectname1)
        {
            a = false;
        }
        if (collision.gameObject.name == targetobjectname2)
        {
            b = false;
        }

    }
}
