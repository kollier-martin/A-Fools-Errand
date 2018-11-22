using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOver : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
 {

	 //Detect if the Cursor starts to pass over the GameObject
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        Debug.Log("Cursor Entering " + name + " GameObject");
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        Debug.Log("Cursor Exiting " + name + " GameObject");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
    }

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		if (OnPointerClick(PointerEventData)) //if actions button is clicked
        {
            /*
                active instance containing attack, magic, defend buttons
            */
            if (OnPointerClick(PointerEventData)) //if attack button is clicked
            {
                /* 
                    attack implementing the attack animation and damage calculation
                */
            }
            else if (OnPointerClick(PointerEventData)) //if magic button is clicked
            {
                /*
                    use magic attack implementing the magic attack sprite
                */
            }
            else if (OnPointerClick(PointerEventData)) //if defend button is clicked
            {
                /*
                    calculate the amount of damage received with the amount of damage deflected
                */
            }
        }
        else if (OnPointerClick(PointerEventData)) //if chat button is clicked
        {
            /*
                Print dialog into text box UI
            */
        }
        else if (OnPointerClick(PointerEventData)) //if flee button is clicked
        {
            /*
                end combat state and return to overworld
                all damage done to player will remain
            */
        }
	}
}
