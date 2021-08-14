using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Iffalled_GameOver : MonoBehaviour
{
    public string ObjectName1;
    public string ObjectName2;
    public string ObjectName3;
    public string targetObjectName;
    
    GameObject showObject1;
    GameObject showObject2;
    GameObject showObject3;
    // Start is called before the first frame update
    void Start()
    {
        showObject1 = GameObject.Find(ObjectName1);
        showObject1.SetActive(false);
        showObject2 = GameObject.Find(ObjectName2);
        showObject2.SetActive(false);
        showObject3 = GameObject.Find(ObjectName3);
        
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            GameObject.Find("Canvas").transform.Find("RawImage").transform.Find("gameover").gameObject.SetActive(true);
            Invoke(nameof(Damage), 3.0f);

        }
    }

    void Damage()
    {
        showObject1.SetActive(true);
        showObject2.SetActive(true);
        
    }

    void OnDestroy()
    {
        CancelInvoke();
    }


}
