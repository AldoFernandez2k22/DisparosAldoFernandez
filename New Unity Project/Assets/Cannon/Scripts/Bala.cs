using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public int velocidad;
    public int direccionArriba;
    public int direccionAdelante;

    public void fuerzaDeBala() {

        velocidad = 1;
        direccionAdelante = 1;
        direccionArriba = 1;
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, direccionArriba * 1000f * velocidad, direccionAdelante * 1000f * velocidad));
        Debug.Log("Se aplicaron Fuerzas");
    }
   

}
