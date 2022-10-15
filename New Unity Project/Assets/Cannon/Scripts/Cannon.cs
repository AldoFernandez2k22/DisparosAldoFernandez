
using UnityEngine;
using System.Collections;
using System;


public class Cannon : MonoBehaviour
{
	public Bala bala;
	public int tiempoEntreDisparo;
	public float tiempoParaDestruir;
	private void Update()
	{
		if (Input.GetKeyDown("j"))
		{
			StartCoroutine(Action(2,tiempoEntreDisparo, Shoot));
			
		}

		if (Input.GetKeyDown("k"))
		{
			StartCoroutine(Action(3, tiempoEntreDisparo, Shoot));
		}

		if (Input.GetKeyDown("l"))
		{
			StartCoroutine(Action(4,tiempoEntreDisparo, Shoot));
			
		}

	}

	private void Shoot()
	{
		Bala clone = Instantiate(bala, new Vector3(0, 4, 2), Quaternion.identity);
		clone.tiempoParaDestruir = tiempoParaDestruir;
		clone.fuerzaDeBala();


		Debug.Log("Se Instancio una Bala");
	}



	IEnumerator Action(int repeticiones ,float tiempo, Action action)
	{   for (int i = 0; i<repeticiones; i++) { 
		yield return new WaitForSeconds(tiempo);
		action();
		}

	}
	
}