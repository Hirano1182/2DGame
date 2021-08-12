using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStoper : MonoBehaviour
{
	public string targetObjectName;
	public float speed = 3;
	public float knockbackpower = 8;
	
	float vx = 0;
	Rigidbody2D rbody;

	void Start()
    {
		rbody = GetComponent<Rigidbody2D>();
		rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void Update()
	{
		if (Input.GetKey("right"))
		{ // もし、右キーが押されたら
			vx = -speed; // 右に進む移動量を入れる
			
		}
		if (Input.GetKey("left"))
		{ // もし、左キーが押されたら
			vx = speed; // 左に進む移動量を入れる
			
		}

	}
	void OnCollisionEnter2D(Collision2D collision)
	{ // 衝突したとき
	  // もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName)
		{
			StartCoroutine("Damage");
			
		}
	}

	IEnumerator Damage()
	{
		GetComponent<OnKeyPress_MoveGravityplus>().enabled = false;
		rbody.AddForce(new Vector2(vx, knockbackpower), ForceMode2D.Impulse);
	
		yield return new WaitForSeconds(1.00f);
		GetComponent<OnKeyPress_MoveGravityplus>().enabled = true;

	}
}