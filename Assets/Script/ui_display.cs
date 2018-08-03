using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_display : MonoBehaviour
{
    public bool is_pressing = false;
    // Use this for initialization
    void Start()
    {
        //collider.isTrigger = true;
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        //プレイヤーtag のオブジェクトが接触したら
        if (other.gameObject.tag == "Player")
        {
            is_pressing = true;
        }
    }
    void OnGUI()
    {
        if (is_pressing)
        {
            // 追憶と人恐れレベルのUIを表示。
            Debug.Log("kakashi");
        }
    }
}