using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukaSwitcher : MonoBehaviour {

    public static bool YukaStatus;
    public bool YukaStatus_W;
    public bool SwitchGroundFlag;
    public string FYukaName;
    public string TYukaName;

    GameObject FYuka;
    GameObject TYuka;

    void Start()
    {
        FYuka = GameObject.Find(FYukaName);
        TYuka = GameObject.Find(TYukaName);
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
                SwitchGroundFlag = false;
            }
            else if (SwitchGroundFlag == true && YukaSwitcher.YukaStatus == true)
            {
                YukaSwitcher.YukaStatus = false;
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
                TYuka.SetActive(true);
            }
            else if (YukaSwitcher.YukaStatus == false)
            {
                TYuka.SetActive(false);
            }

            if (YukaSwitcher.YukaStatus == true)
            {
                FYuka.SetActive(false);
            }
            else if (YukaSwitcher.YukaStatus == false)
            {
                FYuka.SetActive(true);
            }
    }
}
