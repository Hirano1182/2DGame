using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnClickBottom : MonoBehaviour
{
    public string showObjectName;

    GameObject showObject;
    bool flag;
    // Start is called before the first frame update
    void Start()
    { // 最初に行う
      // 消す前に表示オブジェクトを覚えておいて
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false); // 消す
        flag = false;
    }

    public void OnClick()
    {
        if (flag == true)
        {
            flag = false;
            showObject.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            flag = true;
            showObject.SetActive(true);
            Time.timeScale = 0;
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
