using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life4 : MonoBehaviour
{
    public string targetObjectName; // �ڕW�I�u�W�F�N�g���FInspector�Ŏw��
    public string hideObjecttName;  // �����I�u�W�F�N�g���FInspector�Ŏw��

    GameObject hideObject;
    float orgY = 0;
    float ofsetY = 10000; // ���̒l��Y�����ɑ������Ƃŏ���

    private const int MAX_LIFE_COUNT = 3;
    private int lifeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    { // �Փ˂����Ƃ�
      // �����A�Փ˂������̖̂��O���ڕW�I�u�W�F�N�g��������
        if (collision.gameObject.name == targetObjectName && lifeCount == 2)
        {
            // �����yhideObject.SetActive(false); �̑���z
            Vector3 pos = hideObject.transform.position;
            pos.y = orgY + ofsetY;
            hideObject.transform.position = pos;
        }
    }
}
