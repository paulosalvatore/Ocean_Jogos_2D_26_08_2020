using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuloJogador : MonoBehaviour
{
    public Rigidbody2D rb;

    public float forcaPulo = 50f;

    bool estaNoChao;

    public float distancia = 1;

    void Update()
    {
        if (Input.GetButtonDown("Jump") && estaNoChao)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * forcaPulo);
        }
    }

    private void FixedUpdate()
    {
        estaNoChao = Physics2D.Raycast(transform.position, Vector2.down, distancia, 1 << LayerMask.NameToLayer("Chão"));

        Debug.DrawRay(transform.position, Vector2.down * distancia, estaNoChao ? Color.green : Color.red);
    }
}
