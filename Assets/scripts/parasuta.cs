using UnityEngine;
using System.Collections;

public class parasuta : MonoBehaviour {

	
	
	void Start()  {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		
		
		if(other.tag=="trotuar")
		{

			Destroy(this.gameObject);
			
			
			
			
			
		}
	}
}