using UnityEngine;
using System.Collections;

public class UIEnemyHP : MonoBehaviour {

	public enemy attachEnemy;

	// Use this for initialization
	void Start () 
	{
		UILabel lbl = GetComponent<UILabel>();
		lbl.text = "";
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		UILabel lbl = GetComponent<UILabel>();
		lbl.text = "" + attachEnemy.Lifepoint.ToString();

		//lbl.transform.position = camera.WorldToScreenPoint(attachEnemy.transform.position);
		//camera.ViewportToWorldPoint

		if(attachEnemy.Lifepoint <=0)
		{
			Object.Destroy(this.gameObject);
		}

	}
}
