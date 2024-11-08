using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAsteroides : MonoBehaviour
{

    private float limiteX = 11;
    private float limiteZ = 11;
    public GameObject asteroides;

    public GameObject estrellita;
    // Start is called before the first frame update
    
    void Start()
    {
        InvokeRepeating("generar",1,5f);
    }

    // Update is called once per frame
    void Update()
    {
         //StartCoroutine(generar());
    }

    void generaAsteroide(){
        
         float posicionX= Random.Range(-limiteX,limiteX);
        Vector3 posicionAsteroides = new Vector3(posicionX, 0, limiteZ);
        Instantiate(asteroides,posicionAsteroides,asteroides.transform.rotation);
    }
    void generar(){
        generaAsteroide();
        generaAsteroide();
        generaAsteroide();
        generaAsteroide();
        generaAsteroide();
        generarEstrella();
    }

    void generarEstrella(){
        float posicionX = Random.Range(-limiteX,limiteX);
        Vector3 posicionEstrellita = new Vector3(posicionX, 0, limiteZ);
        Instantiate(estrellita,posicionEstrellita,estrellita.transform.rotation);
    }

    
}
