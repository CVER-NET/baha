using UnityEngine;
using System.Collections;

public class UIRestartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnPress()
	{

		Application.LoadLevel("battle");
		GameCore.GameState = "Playing";
		GameCore.remainTime = 20.0f;
		GameCore.playerHP = 100;
		GameCore.atkType = 0;
		this.transform.parent.gameObject.SetActive(false);
		//EndResult.gameObject.SetActive(false);

	
	}
}
