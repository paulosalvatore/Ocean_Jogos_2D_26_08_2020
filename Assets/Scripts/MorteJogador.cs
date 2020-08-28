using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MorteJogador : MonoBehaviour
{
    public float yMorte;

    private void Update()
    {
        if (transform.position.y < yMorte)
        {
            Morrer();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            Morrer();
        }
    }

    void Morrer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
