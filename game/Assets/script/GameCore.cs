using UnityEngine;
using System.Collections;

public class GameCore : MonoBehaviour {

    public static bool timerActive = true;
	public static float timer;
    

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

        
        if (timerActive)
        {
            timer = Time.deltaTime;

        }
        else
        {
            timer = 0;
        }
        //timerActive = true;

	}
}
