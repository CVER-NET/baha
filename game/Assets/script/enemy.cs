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
		GameCore.enemyAry.Remove(this);
		GameCore.timerActive = true;
        Object.Destroy(this.gameObject);

    }



    

}

