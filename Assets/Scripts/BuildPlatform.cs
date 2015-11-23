using UnityEngine;
using System.Collections;


	public class BuildPlatform : MonoBehaviour {

	public static bool buyTurret = false;
	[SerializeField] private GameObject Theonator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (buyTurret);
	}

	void OnMouseDown() {
		if (buyTurret == true) {
			Instantiate (Theonator, this.transform.position, this.transform.rotation);
			Destroy (this.gameObject);
		}
	}


}
