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
            // Calcula a posição desejada da câmera
            Vector3 posiçãoDesejada = jogador.position + offset;
            Vector3 posiçãoSuavizada = Vector3.Lerp(transform.position, posiçãoDesejada, suavidadePosicao);
            transform.position = posiçãoSuavizada;

            // Faz com que a câmera olhe diretamente para o jogador
            transform.LookAt(jogador.position);
        }
    }
}

