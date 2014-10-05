using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour
{

    

    public int Lifepoint = 100;
    public float Lifetime = 1.0f;
   
	// Use this for initialization
	void Start () {
       
        
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * GameCore.timer * 5);

		Lifetime -= GameCore.timer;



        if(Lifetime <= 0.0f)
        {
            Object.Destroy(this.gameObject);
        }

        if(Lifepoint <= 0.0f)
        {
            Enemydestory();

        }


	}

    void Enemydestory()
    {
        GameCore.timerActive = true;
        Object.Destroy(this.gameObject);
    }

     public static void EnemyGetAtked(enemy enemy)
    {
       
        enemy.Lifepoint -= 10;
    }

}

