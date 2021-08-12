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
		{ // �����A�E�L�[�������ꂽ��
			vx = -speed; // �E�ɐi�ވړ��ʂ�����
			
		}
		if (Input.GetKey("left"))
		{ // �����A���L�[�������ꂽ��
			vx = speed; // ���ɐi�ވړ��ʂ�����
			
		}

	}
	void OnCollisionEnter2D(Collision2D collision)
	{ // �Փ˂����Ƃ�
	  // �����A�Փ˂������̖̂��O���ڕW�I�u�W�F�N�g��������
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