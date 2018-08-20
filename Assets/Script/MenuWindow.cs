using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuWindow : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {
        // ラベルを表示する
        GUI.Label(new Rect(10, 10, 100, 100), "ツキノワグマ");
	}
    private void Start()
    {
        //スタートアップ時、表示を消す
        this.gameObject.SetActive(false);
    }
}
