using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameAndLevel : MonoBehaviour
{
    //  1. Giving the character a public name, variable and printing it to the console
    //  1.1 Naming part
    public string Name = "Tulips";
    // 2. Make a private intiture 
    [SerializeField] private int Level = 1;
    void Start()
    {
    //  1.2 printing part
    //  5. printing the outputvalue
    Debug.Log(Calling(Name, Level));
    
    }
    // 3.Generating a Method that has the character name and the level as input variabels.
    private int Calling(string name, int level)
    {
        Debug.Log(name);
        Debug.Log(level);
    // 4. Adds 1 level to Level
        level++;
        return level;
    }
}