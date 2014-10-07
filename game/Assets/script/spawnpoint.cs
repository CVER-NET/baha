using UnityEngine;
using System.Collections;

public class spawnpoint : MonoBehaviour 
{

    public enemy[] enemy;
	public enemy tmpenemy;
	public UIEnemyHP eneHP;
	public UIEnemyHP tmpeneHP;
    public float timer = 1.0f;

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (timer <=0)
        {
			tmpenemy = Instantiate(enemy[Random.Range(0, 3)], transform.position, Quaternion.identity) as enemy;
			tmpeneHP = Instantiate(eneHP, tmpenemy.transform.position, Quaternion.identity) as UIEnemyHP;
			tmpeneHP.attachEnemy = tmpenemy;
			GameCore.enemyAry.Add(tmpenemy);
            timer = ((int)Random.RandomRange(1.0f, 6.0f))* 0.5f ;
			Debug.Log(timer);
        }
               
        timer -= GameCore.timer;
	}
}
