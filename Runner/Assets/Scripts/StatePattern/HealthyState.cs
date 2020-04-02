using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthyState : IState
{
    public void ExecuteCommand(Player player)
    {
        Debug.Log("The player is in Healthy State.");
    }
}
