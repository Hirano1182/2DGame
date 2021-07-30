using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCollision_HPPlus : MonoBehaviour
{
	private const int maxHp = 100;  // 敵キャラのHP最大値を100とする
	private int currentHp;      // 現在のHP
	public Slider slider;     // シーンに配置したSlider格納用
	public string targetObjectName;

	// Use this for initialization
	void Start()
	{
		slider.maxValue = maxHp;    // Sliderの最大値を敵キャラのHP最大値と合わせる
		currentHp = maxHp;      // 初期状態はHP満タン
		slider.value = currentHp;   // Sliderの初期状態を設定（HP満タン）
	}

	// 当たり判定
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == targetObjectName)    // プレイヤーとぶつかったとき
		{
			currentHp -= 10;        // 現在のHPを減らす
			slider.value = currentHp;   // Sliderに現在HPを適用
			Debug.Log("slider.value = " + slider.value);

			// Sliderが最小値になったら（例：ボスキャラを倒したら）
			if (slider.value <= 0)
			{
				Destroy(gameObject);            // 物体を消去
				Destroy(GameObject.Find("Slider")); // Sliderも消去
			}
		}
	}
}
