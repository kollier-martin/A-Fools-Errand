using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatState : MonoBehaviour 
{
	public enum Actions
	{
		START,
		PLAYERCHOICE, //PlayerState.WAITING, ACTION
		DAMAGE,
		ENEMYCHOICE, //MonsterState.WAITING, ACTION
		LOSE,
		WIN
	}
	
	private Actions current;
	
	// Use this for initialization
	void Start () 
	{
		current = Actions.START;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log(current);
		switch(current)
		{
			case (Actions.START):
				break;
			case (Actions.PLAYERCHOICE):
				break;
			case (Actions.ENEMYCHOICE):
				break;
			case (Actions.LOSE):
				break;
			case (Actions.WIN):
				break;
		}	
	}

	/* 
	void progess()
	Will keep up with dialog and health values if we use a health, mp bar
	*/
}
