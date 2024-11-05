using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mueveAsteroide : MonoBehaviour
{
    // Start is called before the first frame update
    private float velocidadAsteroide = 8f;
    private float limiteZ =10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 1*velocidadAsteroide*Time.deltaTime);
        if(transform.position.z< limiteZ){
            Destroy(gameObject);
        }
    }
}
