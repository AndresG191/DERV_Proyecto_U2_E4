using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTransition : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Camera;
    public GameObject MainCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1")){
            CamaraVirtual();
        }
        if(Input.GetKeyDown("2")){
            CamaraMain();
        }
    }

    void CamaraVirtual(){
        Camera.SetActive(true); 
        MainCamera.SetActive(false);
    }

    void CamaraMain(){
        Camera.SetActive(false);
        MainCamera.SetActive(true);
    }

}
