using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{

		switch(collider2D.gameObject.tag)
		{
		case "Player":

			Destroy(gameObject ,2);
			break;
		}
	}
}
