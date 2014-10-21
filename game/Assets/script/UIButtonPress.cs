using UnityEngine;
using System.Collections;

public class UIButtonPress : MonoBehaviour {

	public int locolatkType;
	
	void OnPress ()
    {
		//GameCore.enemyAry[0].Lifepoint -= 10;
		GameCore.atkType = locolatkType;
    }

    void attack()
    {

    }

}
