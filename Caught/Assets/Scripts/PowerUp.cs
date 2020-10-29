using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    private string name;
    private float time; //how long the effect lasts for in seconds

    public PowerUp(string name, float time)
    {
        this.name = name;
        this.time = time;
    }

    public abstract void usePowerUp();
}
