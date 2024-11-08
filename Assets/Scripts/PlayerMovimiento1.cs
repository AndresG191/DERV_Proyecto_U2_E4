using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovimiento1 : MonoBehaviour
{
    [SerializeField] float velocidad_rotacion;
    [SerializeField] float velocidad_movimiento;
    [SerializeField] TextMeshProUGUI texto_restarvida;

    int contadorVida;

    // Start is called before the first frame update

    public int vidas = 3;   //chatgpt
    public int estrellasRecolectadas = 0; // Para contar las estrellas recolectadas
    void Start()
    {

        vidas = 3;
        estrellasRecolectadas = 0; //chatgpt

    }
    void Update()
    {
        //izquierda derecha 
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.right;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += velocidad_movimiento * Time.deltaTime * transform.right;
        }

        if (vidas <= 0)
        {
            //chatgpt
            Debug.Log("Game Over. Reiniciando...");
            //Invoke("ReiniciarJuego", 3f); // Espera 3 segundos antes de reiniciar el juego
            SceneManager.LoadScene(3);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            //LOGICA PARA HACER LO QUE QUIERA EN LA NAVE
            Debug.Log("Restar Vida. Vidas restantes: " + vidas);  //chatgpt
            if (vidas <= 0)
            {
                Debug.Log("Game Over");

                //Invoke("Reiniciar Juego", 3f);
                SceneManager.LoadScene(3);
            }
            if (vidas > 0)
            {
                vidas--;
                texto_restarvida.text = vidas.ToString();    //codigo para restar vidas en pantalla
            }


            //--------------------------------------------------------------------------//
            //condicion
            //si el jugador recive un daño hasta 3 el jugador pierde y reinicia

            //Proximo a realizar...
            //cuando el jugador pierda 3 vidas, reiniciar el juego en automatico despues de 7 segundos
            //cuando el jugador recolecte las 5 estrellas, que pase al siguiente nivel con un cuadro invisible
        }


        // Método para reiniciar el juego
        void ReiniciarJuego()
        {
            // Reiniciar la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // Método para pasar al siguiente nivel
        void PasarAlSiguienteNivel()
        {
            // Cargar la siguiente escena (asegúrate de tener una escena adicional configurada)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


    }
}

