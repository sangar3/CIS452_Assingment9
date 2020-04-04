/*
		 * (Santiago Garcia II)
		 * (HurtState.cs)
		 * (Assignment)
		 * (One of the player health states)
	*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtState : IState
{
    public void ExecuteCommand(Player player)
    {
        Debug.Log("The player is wounded. Please search health points");
    }
}
