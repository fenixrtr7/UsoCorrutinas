using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. Mostrar como podemos tener codigo costoso que se ejecuta en cada fotograma

public class S05A : MonoBehaviour
{
    GameObject[] enemigos;
    // Start is called before the first frame update
    void Start()
    {
        //enemigos = GameObject.FindGameObjectWithTag("Enemigo");   
    }

    // Update is called once per frame
    void Update()
    {
        // Aqui deberia de haber algun codigo costoso que hiciera muchas operaciones
        // Uso los Debug.Log para simular esa parte costosa, ya que el resto del código
        // de ejemplo no lo es.
        Debug.Log("Inicio de la comprobación");
        foreach (GameObject objeto in enemigos)
        {
            Debug.Log("Comprobando con objeto");
            if(Vector3.Distance(transform.position, objeto.transform.position) < 2)
            {
                objeto.GetComponent<_Enemy>().Detectado();
            }
        }
    }
}
