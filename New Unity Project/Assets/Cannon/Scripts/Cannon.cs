using UnityEngine;
using System.Collections;
	using System;


public class Cannon : MonoBehaviour
{
	public GameObject bala;
    private void Update()
    {
		if (Input.GetKeyDown("j")) {
			StartCoroutine(Action(0f, Shoot));
			StartCoroutine(Action(1f, Shoot));
		}

		if (Input.GetKeyDown("k"))
		{
			StartCoroutine(Action(0f, Shoot));
			StartCoroutine(Action(1f, Shoot));
			StartCoroutine(Action(2f, Shoot));
		}

		if (Input.GetKeyDown("l"))
		{
			StartCoroutine(Action(0f, Shoot));
			StartCoroutine(Action(1f, Shoot));
			StartCoroutine(Action(2f, Shoot));
			StartCoroutine(Action(3f, Shoot));
		}

	}
	
	private void Shoot()
	{   
		Instantiate(bala, new Vector3(0,4,2), Quaternion.identity);
		
		Debug.Log("The Cannon has been shoot!");
	}

    

    IEnumerator Action(float tiempo, Action action) {
		yield return new WaitForSeconds(tiempo);
		action();
		 
	}
	
}
