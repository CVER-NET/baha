using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartLine : MonoBehaviour {

   // public GameObject[] enemyAry;
    //public ArrayList enemyAry = new ArrayList();
    public static List<GameObject> objAry;
    public static List<enemy> enemyAry;
    public static enemy nearstEnemy;
        
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
        
	}

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (objAry.Contains(coll.gameObject) == false)
           {
               objAry.Add(coll.gameObject);
                //enemyAry.Add(objAry.)
               // coll.isAdded = true;
               Debug.Log(enemyAry[0]);
           }
       
           // Debug.Log(enemyAry.);     
    }

    void atkenemy()
    {
        //enemy.EnemyGetAtked(enemyAry);

    }

   


   
}
