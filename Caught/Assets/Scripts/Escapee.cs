using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escapee : ControllablePlayer 
{
    private bool currentlyCaptured = false;
    private bool imprisoned = false;
    private Task[] tasks;

    public Escapee(string name, int health, int speed) : base(name, health, speed)
    {
        tasks = new Task[5]; //each player has 5 tasks
    }

    public override void Start()
    {
        throw new System.NotImplementedException();
    }

    public override void Update()
    {
        if (imprisoned)
        {
            return; //stops player being controlled if theyre out
        }
        else
        {
            if (currentlyCaptured)
            {
                return; //stops player being controlled if theyre captured
            }
            else
            {
                //rest of code goes here
            }
        }
    }

    public void addTask(Task task, int pos)
    {
        tasks[pos] = task;
    }

    public void captured()
    {
        currentlyCaptured = true;
        //deactive buttons
        //message on screen
    }

    public bool capturedPlayerInRange()
    {
        return false; 
    }
}
