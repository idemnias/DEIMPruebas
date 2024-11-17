using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{

    // Zona de variables globales
    [SerializeField]
    private float _thrust;
    private Rigidbody _rb;

    private void Awake() {

        _rb = GetComponent<Rigidbody>();
    
    }

    private void OnMouseDown() {
        
        _rb.AddForce(Vector3.up * _thrust);

    }

}
