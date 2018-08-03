using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kakashi : MonoBehaviour {
    //追憶の画像
    public Sprite sprite;
    public Image image;
    public int fearlevel;
    

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
    }
    public void Event()
    {
        Debug.Log("tuioku");
    }
    public void Touch()
    {
        Destroy(this.gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        //プレイヤーtag のオブジェクトが接触したら
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Kakashi");
            image.sprite = sprite;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //プレイヤーtag のオブジェクトが退去したら
        Debug.Log("Kakashi");
        image.sprite = null;
    }
    public float GetFearRadius(int level)
    {
        switch (level)
        {
            case 1:
                return 5.0f;
                break;
            case 2:
                return 10.0f;
                break;
            case 3:
                return 15.0f;
                break;
            case 4:
                return 20.0f;
                break;
            case 5:
                return 25.0f;
                break;
        }
        return 10.0f;
    }

}
