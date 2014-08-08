using UnityEngine;

using System.Collections;



public class ShootDemo : MonoBehaviour {
	
	
	
	public Rigidbody2D projectile;
	
	

	public float speed = 20;
	public int ammo = 10;
	
	
	
	
	
	
	// Use this for initialization
	
	void Start () {

			
	
	
	

		
		
		
	}
	
	
	
	// Update is called once per frame
	
	void Update () {

		
				if (Input.GetButtonDown ("Fire1")) { 

						if (ammo > 0) {
								ammo --;
		
			
								Rigidbody2D instantiatedProjectile = Instantiate (projectile,
			                                               
			                                               transform.position,
			                                               
			                                               transform.rotation)
				
				as Rigidbody2D;

		
								instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (speed, 0, 0));
			
			
			
			
					
		
			}

		}

	}
}