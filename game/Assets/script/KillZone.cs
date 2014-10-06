using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

	public static enemy targetenemy;



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
			targetenemy = coll.gameObject.GetComponent("enemy") as enemy;


		}

	}

	public static void atkTargetenemy()
	{
		if(targetenemy.enemtType == GameCore.atkType)
		{
			targetenemy.Lifepoint -= 20;
		}
		else
		{
			GameCore.playerHP -=10;
		}

	}



}
