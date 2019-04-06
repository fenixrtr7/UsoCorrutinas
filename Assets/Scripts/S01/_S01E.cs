using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. Corutinas dentro de Corutinas.
// 2. Revision de la ejecución paso a paso.

public class _S01E : MonoBehaviour
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

        Debug.Log("Fin del Start");
    }

    IEnumerator MoverCubos()
    {
        foreach (GameObject cubo in Cubos)
        {
            yield return StartCoroutine(MoverCubo(cubo));

            yield return StartCoroutine(GirarCubo(cubo));

            Debug.Log("Despues de iniciar la corutina GirarCubo()");
        }
    }

    IEnumerator MoverCubo(GameObject cubo)
    {
        while( cubo.transform.position.x < MaxX)
        {
            cubo.transform.Translate(Velocidad.x * Time.deltaTime, Velocidad.y * Time.deltaTime, Velocidad.z * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator GirarCubo(GameObject cubo)
    {
        Debug.Log("Inicio de GirarCubo");
        Vector3 VelocidadRotacion = new Vector3(0, 0, 50f);

        while(cubo.transform.rotation.eulerAngles.z < 90)
        {
            Vector3 anguloActual = cubo.transform.rotation.eulerAngles;
            cubo.transform.rotation = Quaternion.Euler(anguloActual + VelocidadRotacion * Time.deltaTime);
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
