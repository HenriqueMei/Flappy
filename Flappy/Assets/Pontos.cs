using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    GameControl controller;

    private void Start()
    {
        controller = FindObjectOfType<GameControl>();
    }

    private void OnTriggerEnter2D(Collider2D colisor)
    {
        controller.Score++;
        //adiciona ponto no texto
        controller.scoreText.text = controller.Score.ToString();
    }
}
