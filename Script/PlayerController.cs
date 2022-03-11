using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 0.01f;
    public ColliderData collideI;
    public ColliderData collideII;
    public ColliderData collideIII;
    private int pressButton = 0;
    public Vector3 playerPos;
    public int score = 0;
    private bool startGame = false;
    public float countCollision;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        collideI = GameObject.Find("Hurdle1").GetComponent<ColliderData>();
        collideII = GameObject.Find("Hurdle2").GetComponent<ColliderData>();
        collideIII = GameObject.Find("Hurdle3").GetComponent<ColliderData>();
        countCollision = 4;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = transform.position;

        if (Input.GetKeyDown(KeyCode.Space) && pressButton == 0)
        {
            transform.localScale = collideI.colliderData;
            pressButton += 1;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && pressButton == 1)
		{
            transform.localScale = collideII.colliderData;
            pressButton += 1;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && pressButton == 2)
        {
            transform.localScale = collideIII.colliderData;
            pressButton = 0;
        }
        if(Input.GetKeyDown(KeyCode.A))
		{
            startGame = true;
		}
       
    }
	private void LateUpdate()
	{
        if(startGame == true)
		{
            playerRb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
            Debug.Log("Its Moving");
            }
		if (countCollision <= 0)
		{
            startGame = false;
            Debug.Log("GameOver");
		}
        
    }

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Hurdle")
		{
            score += 1;
            Debug.Log(score);
		}
	}
	private void OnCollisionEnter(Collision collision)
	{
        if(collision.gameObject.CompareTag("Obstacle"))
		{
            countCollision -= 0.5f;
        }
        
	}




}
