using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public float speed = 1f;
    //rig = fisica do passarinho
    private Rigidbody2D rig;

    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //velocity adiciona velocidade
            //Vector2.up subir
            //speed = velocidade
            rig.velocity = Vector2.up * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D colisor)
    {
        //controla o game over texto
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
