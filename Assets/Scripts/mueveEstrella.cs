using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mueveEstrella : MonoBehaviour
{
    // Start is called before the first frame update
    private float velocidadEstrella = 8f;
    private float limiteZ =10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 1*velocidadEstrella*Time.deltaTime);
        if(transform.position.z< limiteZ){
            Destroy(gameObject);
        }
    }
}
