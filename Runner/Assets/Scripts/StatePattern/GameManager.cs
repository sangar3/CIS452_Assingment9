using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool damaged;
    public static bool gameover;
    public GameObject damagedpanel;
    public GameObject gameoverpanel;
    void Start()
    {
        Debug.Log("GameStart");
        
        damaged = false;

        gameover = false;

    }
    void Update()
    {
        Player player = new Player();
        if(damaged)
        {
            player.Obstalcehit(9); 
            damagedpanel.SetActive(true);
        }
        if (gameover)
        {
            player.Obstalcehit(12);
            Time.timeScale = 0;
            gameoverpanel.SetActive(true);

        }
    }

}
