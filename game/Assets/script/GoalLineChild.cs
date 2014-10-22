using UnityEngine;
using System.Collections;

public class GoalLineChild : MonoBehaviour {
	public GameObject gotenemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        
	}

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
			gotenemy = coll.gameObject;
        }
      
    }

   


   
}
