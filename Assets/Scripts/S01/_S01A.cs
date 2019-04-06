using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. Presentar el problema. Concepto de Update en Unity.

public class _S01A : MonoBehaviour
{
    private GameObject[] Boxes;
    private Vector3 Velocity;
    private const float MaxX= 8.345f;
    // Start is called before the first frame update
    void Start()
    {
        Boxes = new GameObject[3];
        Boxes[0] = GameObject.Find("CuboA");
        Boxes[1] = GameObject.Find("CuboB");
        Boxes[2] = GameObject.Find("CuboC");
        Velocity = new Vector3(7f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject box in Boxes)
        {
            while (box.transform.position.x < MaxX)
            {
                box.transform.Translate(Velocity.x * Time.deltaTime, Velocity.y * Time.deltaTime, Velocity.z * Time.deltaTime);
            }
        }
    }
}
