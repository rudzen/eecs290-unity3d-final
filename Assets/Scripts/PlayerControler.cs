using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {

	public int ProjectileSpeed;
	public GameObject ProjectileSpawnLocation;
	public GameObject Projectile;
	public Element elementalType;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			GameObject newProjectile;
			newProjectile = PhotonNetwork.Instantiate(Projectile.name, ProjectileSpawnLocation.transform.position, ProjectileSpawnLocation.transform.rotation, 0) as GameObject;
			if(elementalType != Element.Paper){
				newProjectile.transform.Rotate(0,90f,0);
				newProjectile.rigidbody.AddForce(ProjectileSpawnLocation.transform.forward * ProjectileSpeed);
				newProjectile.rigidbody.AddTorque(ProjectileSpawnLocation.transform.right * (ProjectileSpeed));
			} else {
				newProjectile.rigidbody.AddForce(ProjectileSpawnLocation.transform.forward * ProjectileSpeed);
			}
		}
	}	
}
