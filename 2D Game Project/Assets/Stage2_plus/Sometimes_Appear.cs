using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometimes_Appear : MonoBehaviour
{
    public string targetName;
    public int Max_Count;

    GameObject Target;

    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        Target = GameObject.Find(targetName);
        Target.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count = count + 1; // �J�E���^�[��1�𑫂���
        if (count >= Max_Count)
        { // �����AmaxCount�ɂȂ�����
            Invoke(nameof(T_Active), 5.0f); //
            count = 0; // �J�E���^�[�����Z�b�g
            Target.SetActive(false);
        }
    }

    private void T_Active()
    {
        Target.SetActive(true);
    }
}
