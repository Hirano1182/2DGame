using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private string groundTag = "Ground";
    private bool isGround = false;
    private bool isGroundEnter, isGroundStay, isGroundExit;

    public bool IsGround()
    {
        if (isGroundEnter || isGroundStay)
        {
            isGround = true;
        }
        else if (isGroundExit)
        {
            isGround = false;
        }

        isGroundEnter = false;
        isGroundStay = false;
        isGroundExit = false;
        return isGround;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            Debug.Log("‰½‚©‚ª”»’è‚É“ü‚è‚Ü‚µ‚½");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            Debug.Log("‰½‚©‚ª”»’è‚É“ü‚è‘±‚¯‚Ä‚¢‚Ü‚·");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == groundTag)
        {
            Debug.Log("‰½‚©‚ª”»’è‚ð‚Å‚Ü‚µ‚½");
        }
    }
}
