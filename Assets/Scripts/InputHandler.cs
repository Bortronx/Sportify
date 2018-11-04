using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputHandler : MonoBehaviour {

    //Make sure to attach these Buttons in the Inspector
    public List<Button> ASelection;

    public Betting NewBettingEvent;

    // Use this for initialization
    void Start () {

        ASelection = new List<Button>();
        //Calls the TaskOnClick/SelectParameter/ButtonClicked method when you click the Button
        for (int i = 0; i < ASelection.Count; i++)
        {
            ASelection[i].onClick.AddListener(delegate { SelectParameter(NewBettingEvent.AvailableSports[i].Name); });
        }

        //.onClick.AddListener(() => ButtonClicked(42));
        //.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update () {
		
	}

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }

    void SelectParameter(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }

}
