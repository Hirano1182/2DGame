using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukaSwitch : MonoBehaviour
{
    public bool YukaStatus = false;
    public string PlayerName;
    public bool SwitchGroundFlag;


    /* Update is called once per frame
    void Update()
    {

    }
    */
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
        if (SwitchGroundFlag == true && YukaStatus == false)
        {
            YukaStatus = true;
            SwitchGroundFlag = false;
        }else if(SwitchGroundFlag == true && YukaStatus == true)
        {
            YukaStatus = false;
            SwitchGroundFlag = false;
        }
    }
}