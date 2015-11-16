using UnityEngine;
using System.Collections;

public class BuyerinoTower : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BuyTurret(){
		BuildPlatform.buyTurret = true;
	}
}
