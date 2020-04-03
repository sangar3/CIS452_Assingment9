using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    IState currentState;

    public Player()
    {
        this.currentState = new HealthyState();
        //Debug.Log("healthyState");
    }
    public void Obstalcehit(int obstacles)
    {
        Debug.Log("obstacles hits to the player: " + obstacles);
        if (obstacles < 5)
            this.currentState = new HealthyState();
        if (obstacles >= 5 && obstacles < 10)
            this.currentState = new HurtState();
        if (obstacles >= 10)
            this.currentState = new DeadState();

        currentState.ExecuteCommand(this);
    }
} 
