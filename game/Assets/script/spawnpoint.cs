using UnityEngine;
using System.Collections;

public class spawnpoint : MonoBehaviour 
{

    public GameObject[] enemy;

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
            Instantiate(enemy[Random.RandomRange(0, 3)], transform.position, Quaternion.identity);
            timer = Random.RandomRange(1.0f, 2.0f);
        }
        
        //timer -= (float)Time.deltaTime;
        timer -= GameCore.timer;
	}
}
