using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterState : MonoBehaviour 
{
	private Monster monster;

	public enum TurnState
	{
		START,
		WAITING,
		ACTION,
		DEAD,
		SELECTING
	}

	public TurnState current;

	// Use this for initialization
	void Start () 
	{
		current = TurnState.START;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log(current);
		switch (current)
		{
			case (TurnState.START):
			break;

			case (TurnState.WAITING):
			break;

			case (TurnState.DEAD):
			break;

			case (TurnState.SELECTING):
			break;

			case (TurnState.ACTION):
			break;
		}
	}
}
