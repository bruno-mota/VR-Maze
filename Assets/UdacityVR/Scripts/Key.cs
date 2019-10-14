using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject keyPoof;
	public Door door;
    //Create a reference to the KeyPoofPrefab and Door

	void Update()
	{
		
	}

	public void OnKeyClicked()
	{
		Vector3 pos = transform.position;
		Instantiate (keyPoof, pos, transform.rotation);
        // Call the Unlock() method on the Door
		Destroy(gameObject);
		door.Unlock();
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
    }

}
