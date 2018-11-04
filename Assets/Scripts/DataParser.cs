using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TextAsset))]
public class DataParser : MonoBehaviour
{

    public TextAsset QuestionFile; 

    // Use this for initialization
    void Start ()
    {

        int num = 0;

        string line;
	    while ((line = QuestionFile.text.Split("\n"[0])[0]) != null)
	    {
	        string[] items = line.Split('\t');
	        int myInteger = int.Parse(items[1]);   // Here's your integer.

	        // Now let's find the path.
	        string path = null;
	        foreach (string item in items)
	        {
	            if (item.StartsWith("item\\") && item.EndsWith(".ddj"))
	                path = item;
	        }

	        // At this point, `myInteger` and `path` contain the values we want
	        // for the current line. We can then store those values or print them,
	        // or anything else we like.

	        num++;
	    }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
