using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform jogador;
    public Vector3 offset;
    public float suavidadePosicao = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        // offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (jogador != null)
        {
            // Calcula a posi��o desejada da c�mera
            Vector3 posi��oDesejada = jogador.position + offset;
            Vector3 posi��oSuavizada = Vector3.Lerp(transform.position, posi��oDesejada, suavidadePosicao);
            transform.position = posi��oSuavizada;

            // Faz com que a c�mera olhe diretamente para o jogador
            transform.LookAt(jogador.position);
        }
    }
}

