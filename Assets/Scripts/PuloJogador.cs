using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PuloJogador : MonoBehaviour
{
    [Header("Componentes")]
    public Rigidbody2D rb;

    [Header("Configurações")]
    public float forcaPulo = 50f;

    bool puloDuploDisponivel = true;

    [Header("Detectores de Chão")]
    public float distancia = 1;

    bool estaNoChao;

    public Transform detectorChao1;

    public Transform detectorChao2;

    void Update()
    {
        if (Input.GetButtonDown("Jump") && puloDuploDisponivel)
        {
            if (!estaNoChao)
            {
                puloDuploDisponivel = false;
            }

            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * forcaPulo);
        }

        Debug.DrawRay(detectorChao1.position, Vector2.down * distancia, estaNoChao ? Color.green : Color.red);
        Debug.DrawRay(detectorChao2.position, Vector2.down * distancia, estaNoChao ? Color.green : Color.red);
    }

    private void FixedUpdate()
    {
        estaNoChao = Physics2D.Raycast(detectorChao1.position, Vector2.down, distancia, 1 << LayerMask.NameToLayer("Chão"))
            || Physics2D.Raycast(detectorChao2.position, Vector2.down, distancia, 1 << LayerMask.NameToLayer("Chão"));

        if (estaNoChao && !puloDuploDisponivel)
        {
            puloDuploDisponivel = true;
        }
    }
}
