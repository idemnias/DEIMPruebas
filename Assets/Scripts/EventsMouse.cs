using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsMouse : MonoBehaviour
{

    private void OnMouseDown() {

        Debug.Log("Actuo cuando hago click con el botón izquierdo del " +
            "ratón sobre el objeto");

    }
    private void OnMouseUp() {

        Debug.Log("Actuo cuando dejo de hacer click con el botón izquierdo del " +
            "ratón sobre el objeto");

    }
    private void OnMouseOver() {

        Debug.Log("Actúo cuando estoy en el collider");

    }
    private void OnMouseExit() {

        Debug.Log("Actúo cuando dejo de estar en el collider");

    }
    private void OnMouseDrag() {

        Debug.Log("Actúo cuando arrastro el objeto");

    }

}
