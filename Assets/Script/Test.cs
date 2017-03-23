using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	#region
	private Rigidbody r;
	#endregion

	/// <summary>
	/// Start this instance.
	/// 獲取遊戲對象 、 初始   都寫在此處
	/// </summary>
	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () { // 連續調用
		if (Input.GetKey (KeyCode.Alpha1)) { //每按一次1 某個用戶按鍵持續按壓的時候
			//給目前遊戲對象施加一個力(向量)
			r.AddForce(new Vector3(0f,10f,0f)); //延y軸正向的力
		}
	}
}
