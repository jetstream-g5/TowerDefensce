using UnityEngine;
using System.Collections;

public class SpriteChanger : MonoBehaviour {

	private SpriteRenderer spriteRenderer;

	[SerializeField]private Sprite theoCookie;
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeSprite(){
		spriteRenderer.sprite = theoCookie;
	}
}
