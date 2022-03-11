using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public Text playerLives;
    private string numberLive; 
    public PlayerController playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        numberLive = playerHealth.countCollision.ToString();
        playerLives.text = "Lives Remaining: " + numberLive;
    }
}
