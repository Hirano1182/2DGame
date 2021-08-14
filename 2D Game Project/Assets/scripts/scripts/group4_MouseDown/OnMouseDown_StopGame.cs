using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、ゲームをストップする
public class OnMouseDown_StopGame : MonoBehaviour {

	void Start () { // 最初に行う
		Time.timeScale = 1; // 時間を動かす
	}

	void OnMouseDown() 
	{
		Time.timeScale = 0;
	}
}
