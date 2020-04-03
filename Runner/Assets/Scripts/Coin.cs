using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public AudioClip coinpickupfx;

    void Update()
    {
        transform.Rotate(50 * Time.deltaTime, 0, 0); //roating x 

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.numberOfCoins += 1;
            Debug.Log("number of coins: " + GameManager.numberOfCoins);
            AudioManager.Instance.PlaySFX(coinpickupfx, 3.0f);
            Destroy(gameObject);
        }
    }
}
