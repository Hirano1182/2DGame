using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_Show : MonoBehaviour
{
    public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
    public string showObjectName;   // 表示オブジェクト名：Inspectorで指定

    GameObject showObject;
    // Start is called before the first frame update
    void Start()
    {
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false); // 消す
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            showObject.SetActive(true); // 消していたものを表示する
        }
    }
}
