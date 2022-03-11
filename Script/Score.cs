using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text playerScore;
    private string scoreShow;
    public PlayerController retrieveScore;
    // Start is called before the first frame update
    void Start()
    {
        retrieveScore = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreShow = retrieveScore.score.ToString();
        playerScore.text = "Score: " + scoreShow;
    }
}
