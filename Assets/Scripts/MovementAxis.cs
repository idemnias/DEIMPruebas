using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAxis : MonoBehaviour
{

    //Variables privadas
    private float _horizontal;
    private float _vertical;
    private float _speed = 2f;
    private float _turnSpeed = 150f;

    void Update()
    {

        InputCube();

    }

    private void InputCube() {

        //Teclas A y D y las flechas < y >
        _horizontal = Input.GetAxis("Horizontal");

        //Teclas W y S y las flechas arriba y abajo de la cruceta de nuestro teclado
        _vertical = Input.GetAxis("Vertical");

        // Aplicamos el eje vertical
        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);

        // Aplicamos el eje horizontal
        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);

    }

}
