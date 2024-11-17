using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsMouse : MonoBehaviour
{

    private void OnMouseDown() {

        Debug.Log("Actuo cuando hago click con el bot�n izquierdo del " +
            "rat�n sobre el objeto");

    }
    private void OnMouseUp() {

        Debug.Log("Actuo cuando dejo de hacer click con el bot�n izquierdo del " +
            "rat�n sobre el objeto");

    }
    private void OnMouseOver() {

        Debug.Log("Act�o cuando estoy en el collider");

    }
    private void OnMouseExit() {

        Debug.Log("Act�o cuando dejo de estar en el collider");

    }
    private void OnMouseDrag() {

        Debug.Log("Act�o cuando arrastro el objeto");

    }

}
