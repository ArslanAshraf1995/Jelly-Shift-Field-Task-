using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderData : MonoBehaviour
{
    private BoxCollider hurdleCollider;
    public Vector3 colliderData;
    // Start is called before the first frame update
    void Start()
    {
        hurdleCollider = GetComponent<BoxCollider>();
        colliderData = hurdleCollider.size;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
