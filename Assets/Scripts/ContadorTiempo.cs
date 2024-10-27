using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorTiempo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto_contadorTiempo;
    int contador;

    void Start()
    {

        contador = 250;
        StartCoroutine(corrutina_contador());
    }

    IEnumerator corrutina_contador()
    {
        while (contador >= 1)
        {
            contador--;
            texto_contadorTiempo.text = contador.ToString();
            yield return new WaitForSeconds(0.5f);
        }


    }

}
