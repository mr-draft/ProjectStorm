using UnityEngine;
using System.Collections;

public class BeaconController : AbstractGamePiece {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.FindChild ("Influence").GetComponent<InfluenceController>().setTeamName(this.getTeamName());
	}
	
}