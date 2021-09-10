using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukaUgokiTimer : MonoBehaviour
{
    public string YukaParentName;
    public float TimerLength;

    GameObject Yukas;
    // Start is called before the first frame update
    void Start()
    {
        Yukas = GameObject.Find(YukaParentName);
        Yukas.SetActive(false);
        Invoke(nameof(DelayMethod), TimerLength);
    }

    void DelayMethod()
    {
        Debug.Log("Delay call");
        Yukas.SetActive(true);
    }

}
