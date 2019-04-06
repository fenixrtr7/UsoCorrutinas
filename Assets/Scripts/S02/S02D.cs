using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. Otra forma de detener las corutinas:
// Terminar "a lo bestia" usando "yield break;"
// (Mostrar qué pasa usando sólo break)

public class S02D : MonoBehaviour
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
        while(true)
        {
            Debug.Log("Hola " + c);
            yield return new WaitForSeconds(1f);
            if(detener)
            {
                yield break;
                // break; // también hubiera valido en este caso.
            }
            c++;
        }
        Debug.Log("Fin de SaludaCadaSegundo");
    }
}
