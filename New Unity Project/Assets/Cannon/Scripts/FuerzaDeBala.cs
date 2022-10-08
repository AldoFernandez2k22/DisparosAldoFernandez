using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzaDeBala : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bala") {
            other.GetComponent<Bala>().fuerzaDeBala();
        }
    }
}
