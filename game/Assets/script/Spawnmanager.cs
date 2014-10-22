using UnityEngine;
using System.Collections;

public class Spawnmanager : MonoBehaviour 
{
	public spawnpoint[] spawnpointAry;
	public int spawnEnemyType;
	public float timer;
	public int spawnpatten;
	// Use this for initialization
	void Start () 
    {
		spawnEnemyType = GameCore.spawnEnemyType;
	}
	
	// Update is called once per frame
	void Update () 
    {
		spawnEnemyType = GameCore.spawnEnemyType;  

		if (timer <=0)
        {

			callspawnEnemy();
            timer = ((int)Random.Range(1.0f, 1.0f))* 0.12f ;
			//Debug.Log (timer);
        }
		     
        timer -= GameCore.timer;
	}

	void callspawnEnemy()
	{
		if(GameCore.specialspawn)
		{
			spawnpatten = Random.Range(1,4);
			GameCore.specialspawn = false;
		}
		else
		{
			spawnpatten = Random.Range (1,7);
		}

		//Debug.Log (spawnpatten);
		switch(spawnpatten)
		{
			case 1:
				spawnpointAry[0].SpawnEnemy(GameCore.spawnEnemyType);
			break;

			case 2:
				spawnpointAry[1].SpawnEnemy(GameCore.spawnEnemyType);
			break;

			case 3:
				spawnpointAry[2].SpawnEnemy(GameCore.spawnEnemyType);
			break;

			case 4:
				spawnpointAry[0].SpawnEnemy(GameCore.spawnEnemyType);
				spawnpointAry[1].SpawnEnemy(GameCore.spawnEnemyType);
			break;

			case 5:
				spawnpointAry[0].SpawnEnemy(GameCore.spawnEnemyType);
				spawnpointAry[2].SpawnEnemy(GameCore.spawnEnemyType);
			break;

			case 6:
				spawnpointAry[1].SpawnEnemy(GameCore.spawnEnemyType);
				spawnpointAry[2].SpawnEnemy(GameCore.spawnEnemyType);
			break;
		

		}
	}

}
