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
        var childTransform = this.gameObject.GetComponentsInChildren<Transform>();

        foreach (Transform child in childTransform)
        {
            if (null != child.GetComponent<SphereCollider>())
            {
                if (child.name == "SphereCollider1")
                {
                    child.GetComponent<SphereCollider>().radius = radius - 0.4f;
                }
                else if (child.name == "SphereCollider2")
                {
                    child.GetComponent<SphereCollider>().radius = radius;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}