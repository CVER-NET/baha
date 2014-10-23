using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameCore : MonoBehaviour {

    public static bool timerActive = true;
	public static float timer;
	public static List<enemy> enemyAry = new List<enemy>();
	public static int atkType = 0; //0 = default ,1 = red , 2 = yellow , 3 = green
	public static int playeratkPoint;
	public static int playerHP = 100;
	public static int spawnEnemyType;
	private static float spawnTypeChangeRemain = 0.0f;
	public static bool specialspawn;
	public static int playerScore = 0;
	public static float remainTime = 20.0f;
	public static string GameState;
	public GameObject EndResult;
    
	void Awake()
	{
		GameState = "Playing";
	}


	// Use this for initialization
	void Start () 
	{	
		playeratkPoint = 10;
	}
	
	// Update is called once per frame
	void Update () 
	{

        
        if (timerActive )
        {
			spawnTypeChangeRemain -= Time.deltaTime;
			timer = Time.deltaTime;
			//Debug.Log (timer);
        }
        else
        {
            timer = 0;
        }


		if(spawnTypeChangeRemain <= 0.0f)
		{
			specialspawn = true;
			spawnEnemyType = Random.Range(0, 3);
			spawnTypeChangeRemain = Random.Range (3.0f ,5.0f); 
		}

		if(remainTime >0 )
		{
			remainTime -= Time.deltaTime;
		}
		else
		{
			remainTime = 0.0f;
			GameState = "END";
			EndResult.gameObject.SetActive(true);
		}

		if(playerHP <=0)
		{
			GameState = "END";
			EndResult.gameObject.SetActive(true);
		}
		//remainTime = Mathf.Lerp (20.0f , 0.0f , Time.deltaTime);
		//remainTime = Mathf.FloorToInt (Time.time);
	}
}
