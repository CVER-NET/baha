using UnityEngine;
using System.Collections;

public class spawnpoint : MonoBehaviour 
{

    public enemy[] enemy;
	public enemy tmpenemy;
	public UIEnemyHP eneHP;
	public UIEnemyHP tmpeneHP;
    public float timer;
	public int spawnEnemyType;

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
			tmpenemy = Instantiate(enemy[spawnEnemyType], transform.position, Quaternion.identity) as enemy;
			tmpeneHP = Instantiate(eneHP, tmpenemy.transform.position, Quaternion.identity) as UIEnemyHP;
			tmpeneHP.attachEnemy = tmpenemy;
			GameCore.enemyAry.Add(tmpenemy);
            timer = ((int)Random.RandomRange(1.0f, 5.0f))* 0.18f ;
           
        }
		     
        timer -= GameCore.timer;
	}
}
