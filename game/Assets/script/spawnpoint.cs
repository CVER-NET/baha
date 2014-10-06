using UnityEngine;
using System.Collections;

public class spawnpoint : MonoBehaviour 
{

    public enemy[] enemy;
	public enemy tmpenemy;
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
			GameCore.enemyAry.Add(tmpenemy);
            timer = Random.RandomRange(1.0f, 2.0f);
        }
               
        timer -= GameCore.timer;
	}
}
