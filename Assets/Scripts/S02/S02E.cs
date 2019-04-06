using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 1. Paso de parámetros a las corutinas

public class S02E : MonoBehaviour
{
    private void OnEnable() 
    {
        StartCoroutine(SaludaCadaSegundo("Hola a todos", 1f));
        StartCoroutine(SaludaCadaSegundo("Adios a todos", 1f));
        StartCoroutine(SaludaCadaSegundo("...", 0.25f));
    }

    private void OnDisable() {
        StopAllCoroutines();
    }

    IEnumerator SaludaCadaSegundo(string mensaje, float espera)
    {
        while (true)
        {
            Debug.Log(mensaje);
            yield return new WaitForSeconds(espera);
        }
    }
}
