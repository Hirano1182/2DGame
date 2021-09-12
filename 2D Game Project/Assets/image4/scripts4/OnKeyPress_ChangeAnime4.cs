using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_ChangeAnime4 : MonoBehaviour
{
    public string rightAnime = ""; //右向き：Inspecterで指定
    public string leftAnime = ""; //左向き：Inspecterで指定

    string nowMode = "";
    void Start()
    {
        nowMode = rightAnime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {//右キーなら
            nowMode = rightAnime;
        }
        if (Input.GetKey("left"))
        {//左キーなら
            nowMode = leftAnime;
        }
    }
    private void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(nowMode);
    }
}
