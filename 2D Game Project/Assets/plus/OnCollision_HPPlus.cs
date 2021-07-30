using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCollision_HPPlus : MonoBehaviour
{
	private const int maxHp = 100;  // �G�L������HP�ő�l��100�Ƃ���
	private int currentHp;      // ���݂�HP
	public Slider slider;     // �V�[���ɔz�u����Slider�i�[�p
	public string targetObjectName;

	// Use this for initialization
	void Start()
	{
		slider.maxValue = maxHp;    // Slider�̍ő�l��G�L������HP�ő�l�ƍ��킹��
		currentHp = maxHp;      // ������Ԃ�HP���^��
		slider.value = currentHp;   // Slider�̏�����Ԃ�ݒ�iHP���^���j
	}

	// �����蔻��
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == targetObjectName)    // �v���C���[�ƂԂ������Ƃ�
		{
			currentHp -= 10;        // ���݂�HP�����炷
			slider.value = currentHp;   // Slider�Ɍ���HP��K�p
			Debug.Log("slider.value = " + slider.value);

			// Slider���ŏ��l�ɂȂ�����i��F�{�X�L������|������j
			if (slider.value <= 0)
			{
				Destroy(gameObject);            // ���̂�����
				Destroy(GameObject.Find("Slider")); // Slider������
			}
		}
	}
}
