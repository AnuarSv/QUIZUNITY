using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AS : MonoBehaviour
{
    public bool isCorrect = false;
    public ScriptManager manager;
    public void Answer() 
    {
        if (isCorrect)
        {
            Debug.Log("Correct");
            manager.correct();
        }
        else
        {
            Debug.Log("Wrong");
            manager.wrong();
        }
    }
}
