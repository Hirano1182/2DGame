using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_ChangeAnime4 : MonoBehaviour
{
    public string rightAnime = ""; //�E�����FInspecter�Ŏw��
    public string leftAnime = ""; //�������FInspecter�Ŏw��

    string nowMode = "";
    void Start()
    {
        nowMode = rightAnime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {//�E�L�[�Ȃ�
            nowMode = rightAnime;
        }
        if (Input.GetKey("left"))
        {//���L�[�Ȃ�
            nowMode = leftAnime;
        }
    }
    private void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(nowMode);
    }
}
