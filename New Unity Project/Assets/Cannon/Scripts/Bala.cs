using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bala : MonoBehaviour
{
    public int velocidad;
    public int direccionArriba;
    public int direccionAdelante;
    public float tiempoParaDestruir;
    







public void Escalado()
    {
        gameObject.transform.localScale += gameObject.transform.localScale;
    }
    public void fuerzaDeBala()
    {

        velocidad = 1;
        direccionAdelante = 1;
        direccionArriba = 1;
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, direccionArriba * 1000f * velocidad, direccionAdelante * 1000f * velocidad));
        Debug.Log("Se aplicaron Fuerzas");

        StartCoroutine(Action(tiempoParaDestruir, Kill));
    }
   
    void Kill() {
        Destroy(gameObject,0f);
    }
    IEnumerator Action(float tiempo, Action action)
    {
        yield return new WaitForSeconds(tiempo);
        action();

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)){
            Escalado();
        }
    }
}
