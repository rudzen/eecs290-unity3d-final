using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {

	public int ProjectileSpeed;
	public GameObject ProjectileSpawnLocation;
	public GameObject Projectile;
	public GameObject RespawnPoint;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			GameObject newProjectile;
			newProjectile = Instantiate(Projectile, ProjectileSpawnLocation.transform.position, ProjectileSpawnLocation.transform.rotation) as GameObject;
			newProjectile.transform.Rotate(0,90f,0);
			newProjectile.rigidbody.AddForce(ProjectileSpawnLocation.transform.forward * ProjectileSpeed);
			newProjectile.rigidbody.AddTorque(ProjectileSpawnLocation.transform.right * (ProjectileSpeed));
		}
	}

	public void Die(){
		gameObject.transform.position = new Vector3 (1000f, 1000f, 1000f);
	}

	public void Respawn(int Team){
		//gameObject.transform = RespawnPoint.transform;
	}
}
