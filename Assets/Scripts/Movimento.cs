using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 1f;

    public Vector2 direcao = Vector2.right;

    public bool habilitarInversaoSentido;

    public float tempoInverter = 1f;

    int sentidoAtual = 1;

    public Space espaco = Space.World;

    private void Start()
    {
        if (habilitarInversaoSentido)
        {
            InvokeRepeating("InverterSentido", tempoInverter, tempoInverter);
        }
    }

    void InverterSentido()
    {
        sentidoAtual *= -1;
    }

    private void Update()
    {
        transform.Translate(direcao * velocidade * sentidoAtual * Time.deltaTime, espaco);
    }
}
