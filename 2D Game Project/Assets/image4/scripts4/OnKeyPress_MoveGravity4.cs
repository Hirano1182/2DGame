using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_MoveGravity4 : MonoBehaviour
{
    public float speed = 3;//�X�s�[�h
    public float jumppower = 8;//�W�����v


    float vx = 0;
    bool leftFlag = false;//��������
    bool pushFrag = false;//�X�y�[�X�L�[���������ςȂ���
    bool jumpFrag = false;//�W�����v����
    bool groundFrag = false;//�����n�ʂɐG��Ă��邩
    Rigidbody2D rbody;

    void Start()
    {//�ŏ��ɍs��//�Փˎ��ɉ�]�����Ȃ�
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {//�����ƍs��
        vx = 0;
        if (Input.GetKey("right"))
        {//�E�L�[�������ꂽ��
            vx = speed;//�E�ɐi�ވړ���
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {//���L�[�������ꂽ��
            vx = -speed;//���ɐi�ވړ���
            leftFlag = false;
        }
        //�X�y�[�X�L�[�������ꂽ�Ƃ��A���������ɐG��Ă�����
        if(Input.GetKey("space") && groundFrag)
        {
            if(pushFrag == false)//�������ςȂ��łȂ����
            {
                jumpFrag = true;//�W�����v�̏���
                pushFrag = true;//�������ςȂ����
            }
        }
        else
        {
            pushFrag = false;//�������ςȂ�����
        }
    }
    void FixedUpdate()
    {//�����ƍs���i��莞�Ԃ��ƂɁj�@//�ړ�����i�d�͂��������܂܁j
        rbody.velocity = new Vector2(vx, rbody.velocity.y);//���E�Ɍ�����ς���
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;//�W�����v����Ƃ�

        if (jumpFrag)
        {
            jumpFrag = false;
            rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {//���������ɐG�ꂽ��
        groundFrag = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {//���������G��Ȃ�������
        groundFrag = false;
    }
}
