using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukaSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public bool is_switch = false;
        public bool Yuka_status = false;
        public string targetObjectName;

}

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SwitchingYuka
{
        if (collision.gameObject.name == targetObjectName)
    {
        GameObject hideObject = GameObject.Find(hideObjectName);
        hideObject.SetActive(false);
    }
}

    void YukaSwitch()
{

}
}
