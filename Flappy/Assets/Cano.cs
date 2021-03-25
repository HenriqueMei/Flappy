using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime deixa mais suave o movimento do cano chegando
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
