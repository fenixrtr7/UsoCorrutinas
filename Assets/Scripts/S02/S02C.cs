using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. Otra forma de detener las corutinas:
// Hacer que lleguen al final de su ejecución usando variables centinela.

public class S02C : MonoBehaviour
{
    bool detener;
    private void OnEnable() {
        detener = false;
        StartCoroutine(SaludaCadaSegundo());
    }

    private void OnDisable() {
        detener = true;
    }

    IEnumerator SaludaCadaSegundo()
    {
        int c = 0;
        while (!detener)
        {
            Debug.Log("Hola " + c);
            yield return new WaitForSeconds(1f);
            c++;
        }
        Debug.Log("Fin de SaludaCadaSegundo");
    }
}
