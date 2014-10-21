using UnityEngine;
using System.Collections;

public class spawnpoint : MonoBehaviour 
{

	public enemy[] enemy; //敵人種類prefab
	public enemy tmpenemy; //儲存剛產生的敵人
	public UIEnemyHP eneHP; //敵人HP prefab
	public UIEnemyHP tmpeneHP; //產人的 ,跟隨敵人的HPUI

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {

	}

	public void SpawnEnemy(int enemytype)
	{
		tmpenemy = Instantiate(enemy[enemytype], transform.position, Quaternion.identity) as enemy;
		tmpeneHP = Instantiate(eneHP, tmpenemy.transform.position, Quaternion.identity) as UIEnemyHP;
		tmpeneHP.attachEnemy = tmpenemy;


	}

}
