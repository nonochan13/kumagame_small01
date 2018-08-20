using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kakashi : MonoBehaviour {
    //追憶の画像
    public Sprite sprite;
    public Image image;
    public int fearlevel;
    public GameObject TuiokuUI;
    void Awake()
    {
        TuiokuUI = GameObject.Find("TuiokuUI");
    }

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
    void OnTriggerStay(Collider other)
    {
        //プレイヤーtag のオブジェクトが接触したら
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Kakashi");
            image.sprite = sprite;
            TuiokuUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //プレイヤーtag のオブジェクトが退去したら
        Debug.Log("Kakashi");
        image.sprite = null;
        TuiokuUI.SetActive(false);
    }

    public float GetFearRadius(int level)
    {
        switch (level)
        {
            case 1:
                return 25.0f;
                break;
            case 2:
                return 50.0f;
                break;
            case 3:
                return 75.0f;
                break;
            case 4:
                return 100.0f;
                break;
            case 5:
                return 125.0f;
                break;
        }
        return 10.0f;
    }

}
