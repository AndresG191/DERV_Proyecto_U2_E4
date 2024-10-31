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
}    
