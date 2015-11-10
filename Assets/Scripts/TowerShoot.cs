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
	[SerializeField]private Transform turret;
	private Quaternion turretPos;

	
	TowerTarget _towerTarget;
	
	void Awake()
	{
		turretPos = turret.transform.rotation;
		_towerTarget = GetComponent<TowerTarget> ();
	}
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
			target = _towerTarget._target;
		if (target) {
			this.transform.rotation = rotation;
			RotateTurret ();
			Shoot ();
		} else{
			ResetTurretRotation();
		}
	}

	void ResetTurretRotation(){
		turretPos.z = 0;
		Debug.Log("ayy lmao");
	}

	void RotateTurret(){
		Vector3 direction = this.transform.position - target.position;
		Vector3 forward = transform.forward;
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
		rotation = Quaternion.Lerp (this.transform.rotation, Quaternion.Euler(0, 0, angle + 90), Time.time * turnSpeed);
	}

	void Shoot(){
		nextFireTime += Time.deltaTime;

		if (nextFireTime >= reloadTime) {
			Instantiate (bullet, this.transform.position, rotation);
			nextFireTime = 0;
		}
	}
}