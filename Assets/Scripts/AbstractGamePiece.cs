//------------------------------------------------------------------------------
// <auto-generated>
//     Denne kode blev oprettet ved hjælp af et værktøj.
//     Runtime-version:4.0.30319.18052
//
//     Ændringer af denne fil kan resultere i ukorrekt funktion, og ændringerne mistes, hvis
//     koden oprettes igen.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

public abstract class AbstractGamePiece : MonoBehaviour{


	//should bee private
	public string teamName;

	public AbstractGamePiece(){

	}
	
	public string getTeamName(){
		return this.teamName;
	}

	public void setTeamName(string newteamName){
		this.teamName = newteamName;
	}
}


