using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukaSwitcher : MonoBehaviour {

    public static bool YukaStatus;
    public bool YukaStatus_W;
    public bool SwitchGroundFlag;
    public string FYukaName;
    public string TYukaName;
    private AudioSource sound01;

    GameObject[] FYuka;
    GameObject[] TYuka;

    void Start()
    {
        FYuka = GameObject.FindGameObjectsWithTag("YukaF");
        TYuka = GameObject.FindGameObjectsWithTag("YukaT");
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound01 = audioSources[0];
    }

    void OnTriggerStay2D(Collider2D collision)
    {
            SwitchGroundFlag = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
            SwitchGroundFlag = false;
     }

    void OnCollisionEnter2D(Collision2D collision)
    { // è’ìÀÇµÇΩÇ∆Ç´
            if (SwitchGroundFlag == true && YukaSwitcher.YukaStatus == false)
            {
                YukaSwitcher.YukaStatus = true;
            sound01.PlayOneShot(sound01.clip);
            SwitchGroundFlag = false;
            }
            else if (SwitchGroundFlag == true && YukaSwitcher.YukaStatus == true)
            {
                YukaSwitcher.YukaStatus = false;
            sound01.PlayOneShot(sound01.clip);
            SwitchGroundFlag = false;
            }
     }

    void Update()
    {
        YukaStatus_W = YukaStatus;
    }

    void FixedUpdate()
    {

        if (YukaSwitcher.YukaStatus == true)
        {
            for (int i = 0; i < TYuka.Length; i++)
            {
                TYuka[i].SetActive(true);
            }

        }
        else if (YukaSwitcher.YukaStatus == false)
        {
            for (int i = 0; i < TYuka.Length; i++)
            {
                TYuka[i].SetActive(false);
            }
        }
        if (YukaSwitcher.YukaStatus == true)
            {
            for (int i = 0; i < FYuka.Length; i++)
            {
                FYuka[i].SetActive(false);
            }
        }
            else if (YukaSwitcher.YukaStatus == false)
            {
            for (int i = 0; i < FYuka.Length; i++)
            {
                FYuka[i].SetActive(true);
            }
        }
    }
}
