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
		lbl.text = "" + attachEnemy.Lifepoint.ToString();

		//lbl.transform.position = camera.WorldToScreenPoint(attachEnemy.transform.position);
		//camera.ViewportToWorldPoint
		pos = gameCamera.camera.WorldToViewportPoint(attachEnemy.transform.position);
		transform.position = uiCamera.camera.ViewportToWorldPoint(pos);
		if(attachEnemy.Lifepoint <=0)
		{
			Object.Destroy(this.gameObject);
		}

	}
}
