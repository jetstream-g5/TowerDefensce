using UnityEngine;
using System.Collections;

[RequireComponent (typeof(TowerTarget))]
public class TowerShoot : MonoBehaviour {
	
	[SerializeField]private GameObject bullet;
	private Quaternion rotation;
	private Transform target;
	[SerializeField]private float turnSpeed = 1f;
	[SerializeField]private float reloadTime;
	private float nextFireTime;
	
	TowerTarget _towerTarget;
	
	void Awake()
	{
		_towerTarget = GetComponent<TowerTarget> ();
	}
	// Use this for initialization
	void Start () {
	
	}

	IEnumerator ReloadTimer(float reloadTime){
		yield return new WaitForSeconds (reloadTime);
	}
	
	// Update is called once per frame
	void Update () {
		target = _towerTarget._target;
		if (target != null) {
			//InvokeRepeating("Shoot", 1f, reloadTime);
			if(Time.time >= nextFireTime){
				Shoot();
			}
		}
		Debug.Log (target);
	}

	void RotateTurret(){
		rotation = Quaternion.Lerp (this.transform.rotation, target.transform.rotation, Time.time * turnSpeed);
	}

	void Shoot(){
		nextFireTime = Time.time + reloadTime;
		Instantiate (bullet, this.transform.position, rotation);
	}
}
