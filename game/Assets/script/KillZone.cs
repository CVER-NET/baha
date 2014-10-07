using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

	public enemy targetenemy;



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

	public void atkTargetenemy()
	{
		if(targetenemy)
		{

			if(targetenemy.enemtType == GameCore.atkType)
			{
				targetenemy.Lifepoint -= 10;
			}
			else
			{
				targetenemy.Lifepoint -= 5;
			}

		}
		else
		{
			GameCore.playerHP -=10;
		}

	}



}
