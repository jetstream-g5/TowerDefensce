using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	
	// Use this for initialization
	HealthBar healthBar;
	//[SerializeField]private Transform healthBarObject;
	void Start () {
		healthBar = GetComponentInChildren<HealthBar> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Bullet") {
			healthBar.LowerHealth();
			Destroy(other.gameObject);
		}
	}

	public void RipEnemy(){
		Destroy (this.gameObject);
	}
}
