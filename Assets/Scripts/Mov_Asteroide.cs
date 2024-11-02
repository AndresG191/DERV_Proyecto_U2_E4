using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Asteroide : MonoBehaviour
{
    public Transform target;
     public float speed;
     void Update() {
         float step = speed * Time.deltaTime;
         transform.position = Vector3.MoveTowards(transform.position, target.position, step);
     }
}
