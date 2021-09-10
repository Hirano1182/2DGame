using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MK_Teleporter : MonoBehaviour
{
    public string Target_Name; //����L�����N�^�[�̖��O
    public Transform Target_Transform; //����L�����N�^�[���w��
    public Transform TelepoTo_Transform;//�e���|�[�g��̃I�u�W�F�N�g

    private AudioSource sound; //���i�����Ă������j

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound = audioSources[0];
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Target�ƂԂ��������Ƀe���|�[�g
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
