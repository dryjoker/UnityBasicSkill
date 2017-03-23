using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour {

	private Rigidbody r4;

	// Use this for initialization
	void Start () {
		r4 = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Alpha4)) {
			//爆炸力
			//第一個參數:爆炸產生之力大小 float
			//第二個參數:爆炸位置 Vector3
			//第三個參數:爆炸有效範圍(半徑) float
			r4.AddExplosionForce(1500f,Vector3.zero,4f);
		}
	}
}
