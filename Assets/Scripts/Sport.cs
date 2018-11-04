using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sport
{
    public string Name;
    public List<string> Players { get; set; }
    public List<string> Teams { get; set; }

    public Sport(string name)
    {
        Name = name;
    }
}
