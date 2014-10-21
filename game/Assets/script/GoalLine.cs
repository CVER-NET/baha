using UnityEngine;
using System.Collections;

public class GoalLine : MonoBehaviour {
	public GoalLineChild[] GoalLineChildary;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(GoalLineChildary[0].gotenemy == null && 
		   GoalLineChildary[1].gotenemy == null &&
		   GoalLineChildary[2].gotenemy == null
		  )
		  	{
				GameCore.timerActive = true; //重啟時間
		  	}

        
	}

  

   
}
