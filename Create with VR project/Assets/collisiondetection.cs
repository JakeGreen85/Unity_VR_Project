using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "bincollider"){
            Debug.Log("Nice Shot!");
            Destroy(gameObject);
        }
    }
}
