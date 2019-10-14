using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public bool locked = true;
	public static bool opening = false;
	public AudioClip open;
	bool hasOpened = false;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 

    void Update() {
		if (opening){
			if (transform.position.y < 7) {
				transform.Translate (0, 2f * Time.deltaTime, 0, Space.World);
				Vector3 pos = transform.position;
				if (!hasOpened) {
					AudioSource.PlayClipAtPoint (open, pos);
					hasOpened = true;
				}
			}
		}
        // If the door is opening and it is not fully raised
            // Animate the door raising up
    }

    public void OnDoorClicked() {
		if (locked == false) {
			opening = true;
		} 
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
    }

    public void Unlock(){
		locked = false;
    }
}
