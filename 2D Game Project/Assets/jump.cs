
using UnityEngine;
using System.Collections;

public class DoubleJumpChara : MonoBehaviour
{

    private Animator animator;
    private CharacterController cCon;
    private Vector3 velocity;
    //�@�ʏ�̃W�����v��
    [SerializeField]
    private float jumpPower = 5f;
    //�@2�i�K�ڂ̃W�����v��
    [SerializeField]
    private float doubleJumpPower = 5.6f;
    //�@�Q�i�K�W�����v�����ǂ���
    private bool isDoubleJump = false;
    //�@��x2�i�K�W�����v�����݂����ǂ���
    private bool tryDoubleJump;

    void Start()
    {
        animator = GetComponent<Animator>();
        cCon = GetComponent<CharacterController>();
        velocity = Vector3.zero;
    }

    void Update()
    {

        //�@�L�����N�^�[�R���C�_���ڒn�A�܂��̓��C���n�ʂɓ��B���Ă���ꍇ
        if (cCon.isGrounded)
        {
            velocity = Vector3.zero;

            //�@���n���Ă�����A�j���[�V�����p�����[�^�ƂQ�i�K�W�����v�t���O��false
            animator.SetBool("Jump", false);
            animator.SetBool("DoubleJump", false);
            isDoubleJump = false;
            tryDoubleJump = false;

            //�@�W�����v
            if (Input.GetButtonDown("Jump")
                && !animator.GetCurrentAnimatorStateInfo(0).IsName("Jump")
                && !animator.IsInTransition(0)
            )
            {
                animator.SetBool("Jump", true);
                velocity.y += jumpPower;
            }
            //�@�P�i�K�ڂ̃W�����v��
        }
        else if (animator.GetBool("Jump")
          && !isDoubleJump
          && !tryDoubleJump
      )
            //�@�W�����v�{�^����2�i�K�ڂ̃W�����v
            if (Input.GetButtonDown("Jump"))
            {
                //�@�A�j���[�V�����Đ��ʒu���擾
                var normalizedTime = Mathf.Repeat(animator.GetCurrentAnimatorStateInfo(0).normalizedTime, 1f);
                Debug.Log(normalizedTime);
                //�@�A�j���[�V�����ʒu��2�i�K�ڂ̃W�����v�����邩�ǂ������߂�
                if (animator.GetCurrentAnimatorStateInfo(0).IsName("Jump")
                && 0.35f <= normalizedTime && normalizedTime <= 0.5f)
                {
                    //�@2�i�K�W�����v�̐ݒ�
                    isDoubleJump = true;
                    animator.SetBool("DoubleJump", true);
                    //�@�L�[�������������ɃL�����N�^�[��������
                    transform.LookAt(transform.position );
                    //�@Y�����ɂQ�i�K�W�����v�͂𑫂�
                    velocity.y += doubleJumpPower;
                }
                else
                {
                    //�@��x��i�K�ڂ̃W�����v�����݂���n�ʂɒ��n����܂ł͏o���Ȃ��悤�ɂ���
                    tryDoubleJump = true;
                }
            }
            //�@�Q�i�K�W�����v���̏���
        }
}