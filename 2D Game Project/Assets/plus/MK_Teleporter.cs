using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MK_Teleporter : MonoBehaviour
{
    public string Target_Name; //操作キャラクターの名前
    public Transform Target_Transform; //操作キャラクターを指定
    public Transform TelepoTo_Transform;//テレポート先のオブジェクト

    private AudioSource sound; //音（無くてもいい）

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound = audioSources[0];
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Targetとぶつかった時にテレポート
        if (col.gameObject.name == Target_Name)
        {
                Telepo();
        }
    }

    void Telepo()
    {
        Target_Transform.position = TelepoTo_Transform.position;
        sound.PlayOneShot(sound.clip);
    }
}
