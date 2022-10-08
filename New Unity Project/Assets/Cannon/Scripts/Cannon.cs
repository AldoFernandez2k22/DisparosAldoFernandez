using UnityEngine;
using System;


public class Cannon : MonoBehaviour
{
	public GameObject bala;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
    }
	
	private void Shoot()
	{
		Instantiate(bala, new Vector3(0,4,2), Quaternion.identity);
		
		Debug.Log("The Cannon has been shoot!");
	}

	
}
