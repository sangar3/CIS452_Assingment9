using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    IState currentState;

    public Player()
    {
        this.currentState = new HealthyState();
        Debug.Log("healthyState");
    }

} 
