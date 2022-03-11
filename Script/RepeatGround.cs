using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatGround : MonoBehaviour
{
    private Vector3 startPos;
    private float midPoint;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        midPoint = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - midPoint)
        {
            transform.position = startPos;
        }
    }
}
