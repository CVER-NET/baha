using UnityEngine;
using System.Collections;

public class GoalLine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       /* if (!Collision.contacts) // 碰撞數量為0
       {
           
            GameCore.timerActive = true;

       }*/
        
	}

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            GameCore.timerActive = false;
        }
       // Debug.Log("Onhit");
    }

   


   
}
