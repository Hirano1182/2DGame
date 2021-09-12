
using UnityEngine;
using System.Collections;

public class DoubleJumpChara : MonoBehaviour
{

    private Animator animator;
    private CharacterController cCon;
    private Vector3 velocity;
    //　通常のジャンプ力
    [SerializeField]
    private float jumpPower = 5f;
    //　2段階目のジャンプ力
    [SerializeField]
    private float doubleJumpPower = 5.6f;
    //　２段階ジャンプ中かどうか
    private bool isDoubleJump = false;
    //　一度2段階ジャンプを試みたかどうか
    private bool tryDoubleJump;

    void Start()
    {
        animator = GetComponent<Animator>();
        cCon = GetComponent<CharacterController>();
        velocity = Vector3.zero;
    }

    void Update()
    {

        //　キャラクターコライダが接地、またはレイが地面に到達している場合
        if (cCon.isGrounded)
        {
            velocity = Vector3.zero;

            //　着地していたらアニメーションパラメータと２段階ジャンプフラグをfalse
            animator.SetBool("Jump", false);
            animator.SetBool("DoubleJump", false);
            isDoubleJump = false;
            tryDoubleJump = false;

            //　ジャンプ
            if (Input.GetButtonDown("Jump")
                && !animator.GetCurrentAnimatorStateInfo(0).IsName("Jump")
                && !animator.IsInTransition(0)
            )
            {
                animator.SetBool("Jump", true);
                velocity.y += jumpPower;
            }
            //　１段階目のジャンプ中
        }
        else if (animator.GetBool("Jump")
          && !isDoubleJump
          && !tryDoubleJump
      )
            //　ジャンプボタンで2段階目のジャンプ
            if (Input.GetButtonDown("Jump"))
            {
                //　アニメーション再生位置を取得
                var normalizedTime = Mathf.Repeat(animator.GetCurrentAnimatorStateInfo(0).normalizedTime, 1f);
                Debug.Log(normalizedTime);
                //　アニメーション位置で2段階目のジャンプをするかどうか決める
                if (animator.GetCurrentAnimatorStateInfo(0).IsName("Jump")
                && 0.35f <= normalizedTime && normalizedTime <= 0.5f)
                {
                    //　2段階ジャンプの設定
                    isDoubleJump = true;
                    animator.SetBool("DoubleJump", true);
                    //　キーを押した方向にキャラクターを向ける
                    transform.LookAt(transform.position );
                    //　Y方向に２段階ジャンプ力を足す
                    velocity.y += doubleJumpPower;
                }
                else
                {
                    //　一度二段階目のジャンプを試みたら地面に着地するまでは出来ないようにする
                    tryDoubleJump = true;
                }
            }
            //　２段階ジャンプ中の処理
        }
}