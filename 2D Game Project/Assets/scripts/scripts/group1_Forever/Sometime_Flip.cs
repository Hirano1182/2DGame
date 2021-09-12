using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ときどき、反転する
public class Sometime_Flip : MonoBehaviour {

	public int maxCount = 10; // 頻度：Inspectorで指定
	public float speed = 1; // スピード：Inspectorで指定

	int count = 0; // カウンター用

	void Start () {	// 最初に行う
		count = 0;  // カウンターをリセット
		this.transform.Translate(0, speed / 200, 0); // 垂直移動する
	}

	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		count = count + 1; // カウンターに1を足して
		if (count >= maxCount) { // もし、maxCountになったら
			this.transform.Translate(0, speed / -200, 0); // 垂直移動する
			count = 0; // カウンターをリセット
		}
	}
}