using UnityEngine;
using System.Collections;

public class UIPlayerScore : MonoBehaviour {
	public int playerScoreUI;
	UILabel lbl;

	// Use this for initialization
	void Start () {
	
		UILabel lbl = GetComponent<UILabel>();
		lbl.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{
		UILabel lbl = GetComponent<UILabel>();
		lbl.text = "Score:" + GameCore.playerScore.ToString();
			
			
	}
}
