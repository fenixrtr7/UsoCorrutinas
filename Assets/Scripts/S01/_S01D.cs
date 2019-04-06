﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. Más de un yield dentro de una corutina

public class _S01D : MonoBehaviour
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
        Velocidad = new Vector3(7f, 0f, 0f);

        StartCoroutine(MoverCubos());
    }

    IEnumerator MoverCubos()
    {
        foreach(GameObject cubo in Cubos)
        {
            // Movemos el cubo.
            while(cubo.transform.position.x < MaxX)
            {
                cubo.transform.Translate(Velocidad.x * Time.deltaTime, Velocidad.y * Time.deltaTime, Velocidad.z * Time.deltaTime);
                Debug.Log("Mueve");
                yield return null;
            }

            // Lo rotamos
            Vector3 VelocidadRotacion = new Vector3(0, 0, 50f);
            while(cubo.transform.rotation.eulerAngles.z < 90)
            {
                Vector3 anguloActual = cubo.transform.rotation.eulerAngles;
                cubo.transform.rotation = Quaternion.Euler(anguloActual + VelocidadRotacion * Time.deltaTime);
                Debug.Log("Gira");
                yield return null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
