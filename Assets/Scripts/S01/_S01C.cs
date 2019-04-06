using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. Funcionamiento de la corutina.
// 2. Orden de ejecicion de los elementos.

public class _S01C : MonoBehaviour
{
    private GameObject[] Cubos;
    private Vector3 Velocidad;
    private const float MaxX = 8.345f;
    // Start is called before the first frame update
    void Start()
    {
        Cubos = new GameObject[3];
        Cubos[0] = GameObject.Find("CuboA");
        Cubos[1] = GameObject.Find("CuboB");
        Cubos[2] = GameObject.Find("CuboC");
        Velocidad = new Vector3(7f, 0, 0);

        StartCoroutine(MoverCubos());
        
        Debug.Log("Fin del Start");
    }

    IEnumerator MoverCubos()
    {
        foreach (GameObject cubo in Cubos)
        {
            while(cubo.transform.position.x < MaxX)
            {
                cubo.transform.Translate(Velocidad.x * Time.deltaTime, Velocidad.y * Time.deltaTime, Velocidad.z * Time.deltaTime);
                yield return null;
            }
        }
        Debug.Log("Fin de MoverCubos()");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
