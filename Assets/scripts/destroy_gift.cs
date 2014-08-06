using UnityEngine;
using System.Collections;

public class destroy_gift : MonoBehaviour {

	
	
	void Start()  {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		
		
		if(other.tag=="Player")
		{
			
			Destroy(this.gameObject);
			
			
			
			
			
		}
	}
}