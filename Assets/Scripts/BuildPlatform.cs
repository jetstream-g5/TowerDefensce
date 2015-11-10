using UnityEngine;
using System.Collections;


	public class BuildPlatform : MonoBehaviour {


	[SerializeField] private GameObject Theonator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Debug.Log("Hey macarena");
		Instantiate(Theonator, this.transform.position, this.transform.rotation);
		Destroy(this.gameObject);
	}


}
