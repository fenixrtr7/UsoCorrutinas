using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. Mostrar cuando Unity deja de ejecutar las corutinas de un objeto.
// (Desactivar el componente y desactivar el objeto)

public class S02A : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SaludaCadaSegundo());
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
    }
}
