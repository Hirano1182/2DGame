using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover3 : MonoBehaviour
{
    private const int MAX_LIFE_COUNT = 3;
    private int lifeCount = 0;
    public string showObjectName;  // �\���I�u�W�F�N�g���FInspector�Ŏw��

    GameObject showObject;
    float orgY = 0;
    float ofsetY = 10000; // ���̒l��Y�����ɑ������Ƃŏ���

    // Start is called before the first frame update
    void Start()
    {
        // �����O�ɕ\���I�u�W�F�N�g���o���Ă�����
        showObject = GameObject.Find(showObjectName);

        // �����yshowObject.SetActive(false); �̑���z
        orgY = showObject.transform.position.y;
        if (orgY > ofsetY)
        {
            orgY -= ofsetY;
        }
        Vector3 pos = showObject.transform.position;
        pos.y = orgY + ofsetY;
        showObject.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
    if (lifeCount == 3)
        {
            // ���Ԃ��~�߂�
            Time.timeScale = 0;
            // �\������yshowObject.SetActive(true); �̑���z
            Vector3 pos = showObject.transform.position;
            pos.y = orgY;
            showObject.transform.position = pos;
        }
    }
}
