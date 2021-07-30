using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStepped_DestroyMe : MonoBehaviour
{
    public string targetobjectName;
    

    void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name == targetobjectName)
        {
            Destroy(this.gameObject);
        }
    }
   
}

   