using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_Show : MonoBehaviour
{
    public string targetObjectName; // �ڕW�I�u�W�F�N�g���FInspector�Ŏw��
    public string showObjectName;   // �\���I�u�W�F�N�g���FInspector�Ŏw��

    GameObject showObject;
    // Start is called before the first frame update
    void Start()
    {
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false); // ����
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            showObject.SetActive(true); // �����Ă������̂�\������
        }
    }
}
