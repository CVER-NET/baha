using UnityEngine;
using System.Collections;

public class UIButtonPress : MonoBehaviour {

	
	void OnClick ()
    {
       // GameCore.timerActive = true ? GameCore.timerActive = false : GameCore.timerActive = true; 
       /* if(GameCore.timerActive)
        {

            GameCore.timerActive = false;
        }
        else
        {
            GameCore.timerActive = true; 

        }*/

       //attack();//攻擊最近的敵人

    }

    void attack(GameObject nearstEnemy)
    {
        StartLine.enemyAry[0].Lifepoint -= 10;
    }

}
