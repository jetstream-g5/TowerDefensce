using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	
	[SerializeField]private Text health;
	private float healthAmount;
	private string NoHealthLeft = "R.I.P";
	[SerializeField]private Slider healthBar;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ();
		healthBar.value -= 1f;
		healthAmount = healthBar.value;
		health.text = healthAmount.ToString();
		if (healthBar.value <= 0) {
			health.text = NoHealthLeft;
		}
	}
}
