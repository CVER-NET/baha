using UnityEngine;
using System.Collections;

public class KillZoneButton : MonoBehaviour {
	UIButton Btn;
	public int buttontype;
	public KillZone kz;
	bool isPress;

	// Use this for initialization
	void Start () 
	{
		//UIButton Btn = GetComponent<UIButton>();


	}
	
	// Update is called once per frame
	void Update () 
	{	
		buttontype = GameCore.atkType;
		if (buttontype == 1)
		{	

			UIButton Btn = GetComponent<UIButton>();
			Btn.defaultColor = new Color(225f , 0.0f , 0.0f , 255f);
		}

		else if (buttontype == 2)
		{	
			UIButton Btn = GetComponent<UIButton>();
			Btn.defaultColor = new Color( 255f, 255f, 0f, 255f);
		}

		else if (buttontype == 3)
		{
			UIButton Btn = GetComponent<UIButton>();
			Btn.defaultColor = new Color( 0f,  255f, 0f, 255f);
		}
	
	}

	void OnPress(bool isDown)
	{
		if(isDown)
		{
			kz.atkTargetenemy();
			//Debug.Log ("pressdown");
		}
	}
}
