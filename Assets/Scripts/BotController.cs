using UnityEngine;
using System.Collections;

public class BotController : AbstractGamePiece {

	public int speed;

	// Use this for initialization
	void Start () {
		this.SayTeam ();
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = speed * new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
	}

	void OnTriggerEnter2D(Collider2D other){
		this.setTeamName(other.gameObject.GetComponent<AbstractGamePiece> ().getTeamName());
			//other.gameObject.transform.parent.gameObject.GetComponent<>().teamName;
		this.SayTeam ();
	}

	void OnTriggerExit2D(Collider2D other){
		base.setTeamName ("Nobody");
		this.SayTeam ();
	}

	private void SayTeam(){
		Debug.Log ("I belong to " + this.getTeamName());
	}
}
