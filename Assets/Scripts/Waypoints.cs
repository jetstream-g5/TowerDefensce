using UnityEngine;
using System.Collections;
public class Waypoints : MonoBehaviour 
{
	private Rigidbody2D rgbd;
	private int _targetWaypoint = 0;
	private Transform _waypoints;
	[SerializeField]private string waypointName;
	public Sprite sprite1;
	private SpriteRenderer spriteRenderer;
	[SerializeField]private int waypoint;
	
	public float movementSpeed = 5f;
	
	// Use this for initialization
	void Start () 
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		rgbd = GetComponent<Rigidbody2D> ();
		_waypoints = GameObject.Find(waypointName).transform;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	
	// Fixed update
	void FixedUpdate()
	{
		handleWalkWaypoints();
	}
	
	// Handle walking the waypoints
	private void handleWalkWaypoints()
	{
		Transform targetWaypoint = _waypoints.GetChild(_targetWaypoint);
		Vector3 relative = targetWaypoint.position - transform.position;
		Vector3 movementNormal = Vector3.Normalize(relative);
		float distanceToWaypoint = relative.magnitude;
		float targetAngle = Mathf.Atan2(relative.y, relative.x) * Mathf.Rad2Deg - 90;

		if (distanceToWaypoint < 0.75)
		{
			if(_targetWaypoint == waypoint){
				spriteRenderer.sprite = sprite1;
			}
			if (_targetWaypoint + 1 < _waypoints.childCount)
			{
				// Set new waypoint as target
				_targetWaypoint++;
			}
			else
			{
				// Inform level script that a unit has reached the last waypoint
				Destroy(gameObject);
				return;
			}
		}
		else
		{
			// Walk towards waypoint
			rgbd.AddForce(new Vector2(movementNormal.x, movementNormal.y) * movementSpeed);
		}
		
		// Face walk direction
		//transform.rotation = Quaternion.Euler(0, 0, targetAngle);
	}
}