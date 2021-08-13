using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iffalled_GameOver : MonoBehaviour
{
    public string ObjectName1;
    public string targetObjectName;
    GameObject showObject1;
    // Start is called before the first frame update
    void Start()
    {
        showObject1 = GameObject.Find(ObjectName1);
        showObject1.SetActive(false);
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            showObject1.SetActive(true);
        }
    }
}
