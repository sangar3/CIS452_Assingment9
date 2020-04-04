/*
		 * (Santiago Garcia II)
		 * (Player.cs)
		 * (Assignment 9)
		 * (Implements state interface. This class represents the state of the context object. Each concrete state class implements a behavior associated with a state of context.)
	*/
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
