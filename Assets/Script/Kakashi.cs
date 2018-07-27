using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kakashi : MonoBehaviour {
    //追憶の画像
    public Sprite sprite;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }
    public void Event()
    {
        Debug.Log("tuioku");
    }
    public void Touch()
    {
        Destroy(this.gameObject);
    }
    public void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Player")
        {
            Debug.Log("kakashi");
        }
    }
}
