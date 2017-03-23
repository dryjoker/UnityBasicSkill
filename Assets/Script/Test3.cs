using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour {

	private Rigidbody r3;

	// Use this for initialization
	void Start () {
		r3 = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Alpha3)) {
			//給當前遊戲物件在特定位置上施加一個力
			//第一個參數:力的向量
			//第二個參數:力要施加至哪個位置
			r3.AddForceAtPosition (new Vector3 (0f,10f,0f),new Vector3(0.5f,0.5f,0.5f));

		}
	}
}
