using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControllablePlayer : MonoBehaviour
{
    protected string name;
    protected int health, speed;
    protected PowerUp currentPowerUp = null;
    static readonly int DEFAULT_SPEED = 10;

    public ControllablePlayer(string name, int health, int speed)
    {
        this.name = name;
        this.health = health;
        this.speed = speed;
    }

    public PowerUp getPowerUp()
    {
        return this.currentPowerUp;
    }

    public void setPowerUp(PowerUp powerUp)
    {
        currentPowerUp = powerUp;
    }

    public void setSpeed(int newSpeedValue)
    {
        speed = newSpeedValue;
    }


    // Start is called before the first frame update
    public abstract void Start();

    // Update is called once per frame
    public abstract void Update();



}
