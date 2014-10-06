using UnityEngine;
using System.Collections;

public class UIButtonPress : MonoBehaviour {

	
	void OnClick ()
    {
		GameCore.enemyAry[0].Lifepoint -= 10;

    }

    void attack()
    {

    }

}
