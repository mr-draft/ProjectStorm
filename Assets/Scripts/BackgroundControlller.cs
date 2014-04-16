using UnityEngine;
using System.Collections;

public class BackgroundControlller : MonoBehaviour {



	// Use this for initialization
	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer>();

		//gets the sprits size in world units
		float width = sr.sprite.bounds.size.x;
		float height = sr.sprite.bounds.size.y;

		//calculates the height of the screen in world units
		double worldScreenHeight = Camera.main.orthographicSize * 2.0;
		//calculates the width of the screen in world units 
		double worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
		//calulates and sets the tranform scale to the correct ratio
		transform.localScale = new Vector3((float)(worldScreenWidth / width), (float)(worldScreenHeight / height), 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}