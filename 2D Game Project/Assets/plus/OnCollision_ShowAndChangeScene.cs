using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_ShowAndChangeScene : MonoBehaviour
{
    float seconds;
    public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
    public string showObjectName;   // 表示オブジェクト名：Inspectorで指定
    public string sceneName;

    GameObject showObject;

    void Start()
    { 
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false); // 消す
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            showObject.SetActive(true);
            Invoke("Load", 5);
        }
    }

    // Update is called once per frame
    void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
