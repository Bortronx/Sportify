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
    public TextAsset QuestionFile;
    public QuestionHandler CurrentQuestionHandler;

    public GameObject[] Page;
    public GameObject CurrentPage;
    private int currentPageIndex = 0;

    void Awake()
    {
        CurrentPage = Page[currentPageIndex];

        AvailableSports = new List<Sport>();
        AvailableSports.Add(new Sport("Soccer"));
        AvailableSports.Add(new Sport("Basketball"));
        AvailableSports.Add(new Sport("Football"));
    }

    void Start()
    {

    }

	
	// Update is called once per frame
	void Update () {
		
	}

    public string[] GetGenerateQuestions(Sport selectedSport, GameEvent selectedGameEvent)
    {
        return new string[4]; //TODO Generate Questions
    }
}
