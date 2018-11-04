using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionHandler
{

    public List<string> PlayerParam;
    public List<string> TeamParam;

    public TextAsset QuestionFile;

    public List<Question> QuestionList;

    public QuestionHandler(Sport sport, GameEvent game)
    {

    }

    public void ParseQuestionData()
    {
        int index = 0;

        string line;

        while ((line = QuestionFile.text.Split("\n"[0])[index]) != null)
        {
            string[] lines = line.Split('\t');

            // Replace text file keywords.
            foreach (string item in lines)
            {
                int playerRandomRange = Random.Range(0, PlayerParam.Count);
                int teamRandomRange = Random.Range(0, TeamParam.Count);

                if (item.Contains("PlayerA"))
                    item.Replace("PlayerA", PlayerParam[playerRandomRange]);
                if (item.Contains("PlayerB"))
                    item.Replace("PlayerB", PlayerParam[(++playerRandomRange) % PlayerParam.Count]);

                if (item.Contains("Teamx"))
                    item.Replace("Teamx", TeamParam[teamRandomRange]);
                if (item.Contains("Teamy"))
                    item.Replace("Teamy", TeamParam[(++teamRandomRange) % TeamParam.Count]);

                if (item.Contains("Q:"))
                {
                    item.Remove(0, 2);
                    QuestionList.Add(new Question(item));
                }

                if (item.Contains("A:"))
                {
                    item.Remove(0, 2);
                    QuestionList[QuestionList.Count - 1].QuestionAnswers.Add(item);
                }

            }

            index++;
        }
    }



}

public class Question
{
    public List<string> QuestionAnswers { get; set; }
    public string QuestionText;

    public Question(string question)
    {
        QuestionText = question;
    }
}
