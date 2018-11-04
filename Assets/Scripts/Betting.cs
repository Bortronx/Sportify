using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Betting : MonoBehaviour
{
    public List<Sport> AvailableSports { get; private set; }
    public Sport SelectedSport;
    public GameEvent SelectedGameEvent;

    void Start()
    {
        AvailableSports = new List<Sport>();
    }

	
	// Update is called once per frame
	void Update () {
		
	}

    public string[] GetGenerateQuestions(Sport selectedSport, GameEvent selectedGameEvent)
    {
        return new string[4]; //TODO Generate Questions
    }
}
