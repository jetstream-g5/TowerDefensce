using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	
	[SerializeField]private Transform spawnpoint;
	public Transform enemy1;
	private float spawnTime = 5f;

	// Use this for initialization
	void Start () {
		//Instantiate (enemy1, spawnpoint.position, spawnpoint.rotation);
		InvokeRepeating ("SpawnEnemy", 0.5f, spawnTime);
	}

	void Update () {

	}
	
	void SpawnEnemy(){
		/*GameObject obj =*/ Instantiate (enemy1, spawnpoint.position, spawnpoint.rotation) /*as GameObject*/;
		//obj.transform.SetParent (this.transform);
	}
	
}
