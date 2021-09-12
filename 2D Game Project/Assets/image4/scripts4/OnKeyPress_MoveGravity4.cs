using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_MoveGravity4 : MonoBehaviour
{
    public float speed = 3;//スピード
    public float jumppower = 8;//ジャンプ


    float vx = 0;
    bool leftFlag = false;//左向きか
    bool pushFrag = false;//スペースキーが押しっぱなしか
    bool jumpFrag = false;//ジャンプ中か
    bool groundFrag = false;//足が地面に触れているか
    Rigidbody2D rbody;

    void Start()
    {//最初に行う//衝突時に回転させない
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {//ずっと行う
        vx = 0;
        if (Input.GetKey("right"))
        {//右キーが押されたら
            vx = speed;//右に進む移動量
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {//左キーが押されたら
            vx = -speed;//左に進む移動量
            leftFlag = false;
        }
        //スペースキーが押されたとき、足が何かに触れていたら
        if(Input.GetKey("space") && groundFrag)
        {
            if(pushFrag == false)//押しっぱなしでなければ
            {
                jumpFrag = true;//ジャンプの準備
                pushFrag = true;//押しっぱなし状態
            }
        }
        else
        {
            pushFrag = false;//押しっぱなし解除
        }
    }
    void FixedUpdate()
    {//ずっと行う（一定時間ごとに）　//移動する（重力をかけたまま）
        rbody.velocity = new Vector2(vx, rbody.velocity.y);//左右に向きを変える
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;//ジャンプするとき

        if (jumpFrag)
        {
            jumpFrag = false;
            rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {//足が何かに触れたら
        groundFrag = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {//足が何も触れなかったら
        groundFrag = false;
    }
}
