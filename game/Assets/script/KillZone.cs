using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

	public enemy targetenemy;
    public int atkPoint = 10;
	public Camera MainCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MainCamera.backgroundColor = Color.Lerp(MainCamera.backgroundColor,Color.black, 0.1f);
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
				targetenemy.Lifepoint -= GameCore.playeratkPoint;
			}
			else
			{
				targetenemy.Lifepoint -= (GameCore.playeratkPoint);
			}

		}
		else
		{
			GameCore.playerHP -=10;
			MainCamera.backgroundColor = Color.red;

		}

	}



}
