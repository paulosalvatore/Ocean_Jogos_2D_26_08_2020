using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    public float velocidade = 1f;

    public bool direcao = true;

    private void Update()
    {
        var sentido = direcao ? 1 : -1;
        transform.Rotate(Vector3.forward * velocidade * sentido * Time.deltaTime);
    }
}
