using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour
{

    

    public int Lifepoint = 100;
    public float Lifetime = 1.0f;
	public int enemtType;
   
	// Use this for initialization
	void Start () {
       
        
	}
	
	// Update is called once per frame
	void Update () {
	

		if(this.transform.position.y == -1.75f)
		{
			GameCore.timerActive = false;
        }

		if (GameCore.timerActive)
		{
			transform.position = Vector3.MoveTowards(transform.position,new Vector3(transform.position.x,-1.75f,transform.position.z), 0.3f);
		}
		
		Lifetime -= GameCore.timer;



        if(Lifetime <= 0.0f)
        {
            Object.Destroy(this.gameObject);
        }

        if(Lifepoint <= 0.0f)
        {
            Enemydestory();

        }
		if(Lifepoint <= 5.0f)
		{
			Color tmpcolor;
			tmpcolor = this.gameObject.GetComponent<SpriteRenderer>().color;
			tmpcolor.a = 0.5f;
			this.gameObject.GetComponent<SpriteRenderer>().color = tmpcolor;
		}

	}

    void Enemydestory()
    {
		GameCore.playerScore += 10;
		GameCore.enemyAry.Remove(this);
		//GameCore.timerActive = true;//不要用死亡重啟時間
        Object.Destroy(this.gameObject);

    }



    

}

