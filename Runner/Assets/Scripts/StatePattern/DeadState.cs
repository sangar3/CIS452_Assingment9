﻿/*
		 * (Santiago Garcia II)
		 * (DeadState.cs)
		 * (Assignment)
		 * (One of the player health states)
	*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadState : IState
{
    public void ExecuteCommand(Player player)
    {
        Debug.Log("The player is dead. Game Over.");
    }
}