using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Lifecount : MonoBehaviour
{
	public string targetObjectName; // �ڕW�I�u�W�F�N�g���FInspector�Ŏw��
	public int addValue = 1;    // �����ʁFInspector�Ŏw��

	void OnCollisionEnter2D(Collision2D collision)
	{ // �Փ˂����Ƃ�
	  // �����A�Փ˂������̖̂��O���ڕW�I�u�W�F�N�g��������
		if (collision.gameObject.name == targetObjectName)
		{
			// �J�E���^�[�̒l�𑝂₷
			LifeCounter.life = LifeCounter.life + addValue;
		}
	}
}