using UnityEngine;
using System.Collections;

public class TowerTarget : MonoBehaviour {

	public Transform _target;
	[SerializeField]private float _targetingRadius;
	private int _layerMask;

	void Start(){
		_layerMask = LayerMask.GetMask ("Enemy");
	}
	// Update is called once per frame
	void Update () {
		Collider2D col = Physics2D.OverlapCircle (this.transform.position, _targetingRadius, _layerMask);
		//_target = col;
		_target = col.gameObject.transform;
		//Debug.Log (col);
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere (this.transform.position, _targetingRadius);
	}
}