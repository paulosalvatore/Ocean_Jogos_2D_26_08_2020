using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoBackground : MonoBehaviour
{
    public Transform jogador;

    public float velocidade = 1f;

    private void Update()
    {
        transform.position = jogador.position * velocidade;
    }
}
