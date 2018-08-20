using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderUpdate : MonoBehaviour
{
    SphereCollider col;
    private float radius;

    // Use this for initialization
    void Start()
    {
        var kakashi = GetComponent<Kakashi>();
        radius = kakashi.GetFearRadius(kakashi.fearlevel);
        GameObject emptyGameObject = new GameObject("SphereCollider2");
        //emptyGameObjectをKakashi子供として設定する
        emptyGameObject.transform.SetParent(transform, false);
        //クマが近寄れない範囲のSphereColliderをつける
        emptyGameObject.AddComponent<SphereCollider>();


        var childTransform = this.gameObject.GetComponentsInChildren<Transform>();

        foreach (Transform child in childTransform)
        {
            if (null != child.GetComponent<SphereCollider>())
            {
                if (child.tag == "Kakashi")
                {
                    child.GetComponent<SphereCollider>().radius = radius;

                }
                else if (child.name == "SphereCollider2")
                {
                    child.GetComponent<SphereCollider>().radius = radius - 2.0f;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}