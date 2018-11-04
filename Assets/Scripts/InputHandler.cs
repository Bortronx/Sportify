using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Betting))]
public class InputHandler : MonoBehaviour {

    //Button prefabs.
    public GameObject SportButton;
    public GameObject PromptButton;
    public GameObject AnswerButton;

    //Selection Buttons
    public List<GameObject> ASelection;

    public Betting NewBettingEvent;

    // Use this for initialization
    void Start () {

        NewBettingEvent = GetComponent<Betting>();
        ASelection = new List<GameObject>();

        Vector3 lastButtonPosition = NewBettingEvent.CurrentPage.transform.position
                                     + new Vector3(0f, -30f, 0f);

        foreach (Sport aSport in NewBettingEvent.AvailableSports)
        {
            GameObject newButton = Instantiate(SportButton) as GameObject;
            newButton.transform.SetParent(NewBettingEvent.CurrentPage.transform, false);
            ASelection.Add(newButton);
            newButton.transform.localPosition = new Vector3(0f, lastButtonPosition.y - 30f, 0f);
            newButton.transform.GetChild(0).GetComponent<Text>().text = aSport.Name;
            newButton.SetActive(true);
            lastButtonPosition = newButton.transform.localPosition;
        }


        //Calls the TaskOnClick/SelectParameter/ButtonClicked method when you click the Button
        for (int i = 0; i < ASelection.Count; i++)
        {
            ASelection[i].GetComponent<Button>().onClick.AddListener(delegate { SelectParameter(NewBettingEvent.AvailableSports[i].Name); });
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
