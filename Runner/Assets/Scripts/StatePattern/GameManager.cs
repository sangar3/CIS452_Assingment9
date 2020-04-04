/*
		 * (Santiago Garcia II)
		 * (GameManager.cs)
		 * (Assignment 9)
		 * (the client, It holds the object of concrete state object that changes its state; So, State of context class object is also changed.)
	*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool damaged;
    public static bool gameover;
    public GameObject damagedpanel;
    public GameObject gameoverpanel;

    public static int numberOfCoins;
    public Text cointext;

    void Start()
    {
        Debug.Log("GameStart");
        Time.timeScale = 1;
        damaged = false;

        gameover = false;
        numberOfCoins = 0 ;
        cointext.text = numberOfCoins.ToString();

    }
    void Update()
    {
        Player player = new Player();
        if(damaged)
        {
            player.Obstalcehit(9); 
            damagedpanel.SetActive(true);
        }
        cointext.text = numberOfCoins.ToString(); 
        if (gameover)
        {
            player.Obstalcehit(12);
            Time.timeScale = 0;
            damagedpanel.SetActive(false);
            gameoverpanel.SetActive(true);


        }
    }

}
