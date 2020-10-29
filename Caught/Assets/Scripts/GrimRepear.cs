using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimReaper : ControllablePlayer
{
    private bool carryingPLayer = false;
    private Escapee currentCapturedPlyer = null;

    public GrimReaper(string name, int health, int speed) : base(name, health, speed)
    {

    }

    public override void Start()
    {
        throw new System.NotImplementedException();
    }

    public override void Update()
    {
        throw new System.NotImplementedException();
    }

    public bool playerInRange()
    {
        //checks if a player is in range to capture
        return false;
    }

    public void capture()
    {
        //disables escapee
    }
}
