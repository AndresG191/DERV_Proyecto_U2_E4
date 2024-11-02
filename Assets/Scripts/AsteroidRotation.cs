using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
    // Start is called before the first frame update

    public float vel_rot;
    private Rigidbody rig;

    void Awake(){
        rig = GetComponent<Rigidbody>();
    }
    void Start()
    {
        Vector3 angularVelocity = new Vector3(Random.Range(-1,1), Random.Range(-1,1), Random.Range(-1,1)).normalized;
        rig.angularVelocity = angularVelocity * vel_rot;
    }


}
