using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoNovo : MonoBehaviour
{
    public GameObject cano;
    //controle de altura
    public float height;
    //tempo de spawn
    public float maxTime;
    //Contador
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newCano = Instantiate(cano);
        //Criar novo cano em nova posição e valor aleatorio para subir ou descer (height)
        newCano.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        //contador de tempo
        if(timer > maxTime)
        {
            GameObject newCano = Instantiate(cano);
            newCano.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newCano, 20f);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
