/*
		 * (Santiago Garcia II)
		 * (IState.cs)
		 * (Assignment 9)
		 * (This is an interface which defines the behavior associated with a state of the context object.)
	*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void ExecuteCommand(Player player);
}