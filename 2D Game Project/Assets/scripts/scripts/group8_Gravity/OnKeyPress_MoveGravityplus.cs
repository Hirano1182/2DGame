using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �L�[�������ƁA�ړ�����i�d�͑Ή��Łj
public class OnKeyPress_MoveGravityplus : MonoBehaviour
{

	public float speed = 3; // �X�s�[�h�FInspector�Ŏw��
	public float jumppower = 8;  // �W�����v�́FInspector�Ŏw��

	float vx = 0;
	bool leftFlag = false; // ���������ǂ���
	bool pushFlag = false; // �X�y�[�X�L�[���������ςȂ����ǂ���
	bool jumpFlag = false; // �W�����v��Ԃ��ǂ���
	bool groundFlag = false; // ���������ɐG��Ă��邩�ǂ���
	public int secondjump = 0;
	Rigidbody2D rbody;

	void Start()
	{ // �ŏ��ɍs��
	  // �Փˎ��ɉ�]�����Ȃ�
		rbody = GetComponent<Rigidbody2D>();
		rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void Update()
	{ // �����ƍs��
		if(secondjump >= 3)
        {
			secondjump = 0;
        }
		vx = 0;
		if (Input.GetKey("right"))
		{ // �����A�E�L�[�������ꂽ��
			vx = speed; // �E�ɐi�ވړ��ʂ�����
			leftFlag = false;
		}
		if (Input.GetKey("left"))
		{ // �����A���L�[�������ꂽ��
			vx = -speed; // ���ɐi�ވړ��ʂ�����
			leftFlag = true;
		}
		if (Input.GetKey("space"))
		{

			if (pushFlag == false)
			{ // �������ςȂ��łȂ����
				secondjump++;
				pushFlag = true; // �������ςȂ����

			}
		}
		else
		{
			pushFlag = false; // �������ςȂ�����
		}
		// �����A�X�y�[�X�L�[�������ꂽ�Ƃ��A���������ɐG��Ă�����
		if (Input.GetKey("space") && groundFlag)
		{
			
			if (pushFlag == false)
			{ // �������ςȂ��łȂ����
				jumpFlag = true; // �W�����v�̏���
				pushFlag = true; // �������ςȂ����
				
			}
		}
		else
		{
			pushFlag = false; // �������ςȂ�����
		}
		if (Input.GetKey("space") && groundFlag == false && secondjump <= 2)
		{
			
			if (pushFlag == false)
			{ // �������ςȂ��łȂ����
				jumpFlag = true; // �W�����v�̏���
				pushFlag = true; // �������ςȂ����
				
			}
		}
		else
		{
			pushFlag = false; // �������ςȂ�����
		}
	    
	}
	
	void FixedUpdate()
	{ // �����ƍs���i��莞�Ԃ��ƂɁj
	  // �ړ�����i�d�͂��������܂܁j
		rbody.velocity = new Vector2(vx, rbody.velocity.y);
		// ���E�Ɍ�����ς���
		this.GetComponent<SpriteRenderer>().flipX = leftFlag;
		// �����A�W�����v����Ƃ�
		if (jumpFlag)
		{
			jumpFlag = false;
			rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
		}
	}
	void OnTriggerStay2D(Collider2D collision)
	{ // ���������ɐG�ꂽ��
		groundFlag = true;
	}
	void OnTriggerExit2D(Collider2D collision)
	{ // ���ɉ����G��Ȃ�������
		groundFlag = false;
	}
}