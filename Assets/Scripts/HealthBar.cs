using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	EnemyHealth enemyHealth;
	[SerializeField]private Transform enemy;
	private float Health = 100;
	// Use this for initialization
	void Start () {
		enemyHealth = GetComponentInParent<EnemyHealth> ();
		transform.position = new Vector3 (enemy.position.x, enemy.position.y + 1, enemy.position.z);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void LowerHealth(){
		Health = Health - 20;
		transform.localScale -= new Vector3 (0.4f, 0, 0);
		if(Health <= 0){
			enemyHealth.RipEnemy();
		}
	}
}
