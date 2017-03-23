using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

	private Rigidbody r2;

	// Use this for initialization
	void Start () {
		r2 = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Alpha2)) {
			//給當前遊戲物件施加一個力矩/扭轉  , 以y軸為力矩可以使物體旋轉
			r2.AddTorque (new Vector3 (0f,10f,0f));
		}
	}
}
