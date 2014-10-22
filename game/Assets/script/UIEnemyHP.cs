using UnityEngine;
using System.Collections;

public class UIEnemyHP : MonoBehaviour {

	public enemy attachEnemy;
	//public Transform target;
	public GameObject gameCamera;
	public GameObject uiCamera;
	Vector3 pos;


	// Use this for initialization
	void Start () 
	{
		UILabel lbl = GetComponent<UILabel>();
		lbl.text = "";
		gameCamera = GameObject.Find ("Main Camera");
		uiCamera = GameObject.Find ("UI Root/Camera");
	}
	
	// Update is called once per frame
	void Update () 
	{
		UILabel lbl = GetComponent<UILabel>();
		//lbl.text = "" + attachEnemy.Lifepoint.ToString();
        //lbl.text = "" + attachEnemy.Lifepoint / atk;
        if (attachEnemy.enemtType == GameCore.atkType)
        {
			lbl.text = "" + (Mathf.Ceil ((float)attachEnemy.Lifepoint / (float)GameCore.playeratkPoint)); 
			//Debug.Log (Mathf.Ceil ((float)attachEnemy.Lifepoint / (float)GameCore.playeratkPoint));
        }
        else if (attachEnemy.enemtType != GameCore.atkType)
        {
			lbl.text = "" + attachEnemy.Lifepoint / (GameCore.playeratkPoint / 2) ;
        }
		//lbl.transform.position = camera.WorldToScreenPoint(attachEnemy.transform.position);
		//camera.ViewportToWorldPoint
		pos = gameCamera.camera.WorldToViewportPoint(attachEnemy.transform.position);
		transform.position = uiCamera.camera.ViewportToWorldPoint(pos);
        if (attachEnemy.Lifepoint <= 0 || attachEnemy.Lifetime <= 0.1f)
		{
			Object.Destroy(this.gameObject);
		}

	}
}
