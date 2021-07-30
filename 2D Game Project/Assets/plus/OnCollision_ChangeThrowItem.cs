using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_ChangeThrowItem : MonoBehaviour
{
    public  GameObject newPrefabA;
    public  GameObject newPrefabB;
    public int maxcount = 20;

    public string firstobjectname;
    public string secondobjectname;

    public float throwX = 4;
    public float throwY = 8;
    public float offsetX = 1;
    public float offsetY = -1;

    bool pushFlag = false;
    bool leftFlag = false;
	bool rightFlag = false;
    int itemflag =  0;
	int ammo = 0;
	
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == firstobjectname)
        {
			itemflag = 1;
			ammo = 0;
        }
        if (collision.gameObject.name == secondobjectname)
        {
			itemflag = 2;
			ammo = 0;
        }
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey("right"))
		{ 
			leftFlag = false;
			rightFlag = true;
			


		}
		if (Input.GetKey("left"))
		{ 
			leftFlag = true;
			rightFlag = false;

		}
		if (Input.GetKey("up"))
		{
			if (pushFlag == false)
			{
				ammo++;
				pushFlag = true;
				Vector3 area = this.GetComponent<SpriteRenderer>().bounds.size;
				Vector3 newPos = this.transform.position;
				newPrefabA.GetComponent<SpriteRenderer>().flipY = rightFlag;
				newPrefabA.GetComponent<SpriteRenderer>().flipX = leftFlag;
				newPos.y += offsetY;
				newPos.x += offsetX;
				
				if (itemflag == 1)
				{
					GameObject newGameObject = Instantiate(newPrefabA) as GameObject;
					newPos.z = -5; 
					newGameObject.transform.position = newPos;
					Rigidbody2D rbody = newGameObject.GetComponent<Rigidbody2D>();
					if (leftFlag)
					{
						
						rbody.AddForce(new Vector2(-throwX, throwY), ForceMode2D.Impulse);
						
						if (ammo >= 20)
						{
							itemflag = 0;
						}
					}
					else
					{
						rbody.AddForce(new Vector2(throwX, throwY), ForceMode2D.Impulse);
						if (ammo >= 20)
						{
							itemflag = 0;
						}
					}
				}
				if(itemflag == 2) {
					GameObject newGameObject = Instantiate(newPrefabB) as GameObject;
					newPos.z = -5; 
					newGameObject.transform.position = newPos;
					Rigidbody2D rbody = newGameObject.GetComponent<Rigidbody2D>();
					if (leftFlag)
					{
						
						rbody.AddForce(new Vector2(-throwX, throwY), ForceMode2D.Impulse);
						
						if (ammo >= 20)
						{
							itemflag = 0;
						}
					}
					else
					{
						rbody.AddForce(new Vector2(throwX, throwY), ForceMode2D.Impulse);
						if (ammo >= 20)
						{
							itemflag = 0;
						}

					}
				}

				
			}
		}
		else
		{
			pushFlag = false;
		}
	}
}
