using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	[SerializeField]private float bulletSpeed;
	private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		StartCoroutine (DestroyBullet (3f));
	}

	IEnumerator DestroyBullet(float destroyTimer){
		yield return new WaitForSeconds (destroyTimer);
		Destroy (this.gameObject);
	}
	// Update is called once per frame
	void Update () {
		//transform.Translate (transform.forward * bulletSpeed * Time.deltaTime);
		rb2d.velocity = new Vector2 (bulletSpeed, 0f);
	}
}