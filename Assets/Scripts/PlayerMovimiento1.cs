using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento1 : MonoBehaviour
{
   [SerializeField] float velocidad_rotacion;
    [SerializeField] float velocidad_movimiento;

    // Start is called before the first frame update
    void Start()
    {
        
    }
       void Update()
    {   
            //izquierda derecha 
         if(Input.GetKey(KeyCode.A)){
            transform.position += velocidad_movimiento * -1* Time.deltaTime * transform.right;
        }   else if(Input.GetKey(KeyCode.D)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.right;            
        }
         
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Enemy")){
            Destroy(other.gameObject);
            //LOGICA PARA HACER LO QUE QUIERA EN LA NAVE
            Debug.Log("RestarVida");
            //Proximo a realizar...
            //cuando el jugador pierda 3 vidas, reiniciar el juego en automatico despues de 7 segundos
            //cuando el jugador recolecte las 5 estrellas, que pase al siguiente nivel con un cuadro invisible
        }
    }
}    
