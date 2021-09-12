using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover3 : MonoBehaviour
{
    private const int MAX_LIFE_COUNT = 3;
    private int lifeCount = 0;
    public string showObjectName;  // 表示オブジェクト名：Inspectorで指定

    GameObject showObject;
    float orgY = 0;
    float ofsetY = 10000; // この値をY方向に足すことで消す

    // Start is called before the first frame update
    void Start()
    {
        // 消す前に表示オブジェクトを覚えておいて
        showObject = GameObject.Find(showObjectName);

        // 消す【showObject.SetActive(false); の代わり】
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
            // 時間を止める
            Time.timeScale = 0;
            // 表示する【showObject.SetActive(true); の代わり】
            Vector3 pos = showObject.transform.position;
            pos.y = orgY;
            showObject.transform.position = pos;
        }
    }
}
