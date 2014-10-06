using UnityEngine;
using System.Collections;

public class UIPlayerHP : MonoBehaviour {
	public int playerHPUI;
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
		lbl.text = "PlayerHP:" + GameCore.playerHP.ToString();
			
			
	}
}
