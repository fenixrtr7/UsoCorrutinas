using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Enemy : MonoBehaviour
{
    bool detectado;
    MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Detectado()
    {
        if (!detectado)
        {
            detectado = true;
            StartCoroutine(Parpadeo());
        }
    }

    IEnumerator Parpadeo()
    {
        for (int c = 0; c < 10; c++)
        {
            meshRenderer.enabled = !meshRenderer.enabled;
            yield return new WaitForSeconds(0.25f);
        }
        meshRenderer.enabled = true;
        detectado = false;
    }
}

