using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. Corutinas activas siempre que el componente este activo.
// 2. Desmontar que el StopAllCoritines detiene todas las corutinas iniciadas por este componente.

public class S02B : MonoBehaviour
{
    void OnEnable () {
        StartCoroutine(SaludaCadaSegundo());
    }
    private void OnDisable() {
        StopAllCoroutines();
    }

    IEnumerator SaludaCadaSegundo()
    {
        int c = 0;
        while(true)
        {
            Debug.Log("Hola " + c);
            yield return new WaitForSeconds(1f);
            c++;
        }
        Debug.Log("Fin de SaludaCadaSegundo");
    }
}
