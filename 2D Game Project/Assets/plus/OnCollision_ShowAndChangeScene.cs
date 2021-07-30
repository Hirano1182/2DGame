using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_ShowAndChangeScene : MonoBehaviour
{
    float seconds;
    public string targetObjectName; // �ڕW�I�u�W�F�N�g���FInspector�Ŏw��
    public string showObjectName;   // �\���I�u�W�F�N�g���FInspector�Ŏw��
    public string sceneName;

    GameObject showObject;

    void Start()
    { 
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false); // ����
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
