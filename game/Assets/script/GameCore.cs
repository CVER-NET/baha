using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameCore : MonoBehaviour {

    public static bool timerActive = true;
	public static float timer;
	public static List<enemy> enemyAry = new List<enemy>();
	public static int atkType = 0; //0 = default ,1 = red , 2 = yellow , 3 = green
	public static int playerHP = 100;
	public static int spawnEnemyType;
	private static float spawnTypeChangeRemain = 0.0f;


    
	void Awake()
	{

	}


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		spawnTypeChangeRemain -= Time.deltaTime;
        
        if (timerActive)
        {
			timer = Time.deltaTime;
			//Debug.Log (timer);
        }
        else
        {
            timer = 0;
        }


		if(spawnTypeChangeRemain <= 0.0f)
		{
			spawnEnemyType = Random.Range(0, 3);
			spawnTypeChangeRemain = Random.Range (3.0f ,5.0f); 
		}

	}
}
