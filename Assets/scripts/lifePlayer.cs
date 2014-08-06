using UnityEngine;
using System.Collections;

public class lifePlayer : MonoBehaviour
{
	//Fields
	public int lives = 5;


	//Trigger Function
	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "enemy")
		{

			lives -= 1;

		}
		else if(other.tag=="medkit")
		{
			lives +=5;
		}

			 if (lives == 0)


		Destroy(this.gameObject);

	
}

}