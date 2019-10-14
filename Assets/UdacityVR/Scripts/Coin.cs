﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject coinPoof;
    //Create a reference to the CoinPoofPrefab

    public void OnCoinClicked() {
		Vector3 pos = transform.position;
		Instantiate (coinPoof, pos, transform.rotation);
		Destroy (gameObject);
			}
			
}
	
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
    


