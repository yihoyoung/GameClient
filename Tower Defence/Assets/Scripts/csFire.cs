using UnityEngine;
using System.Collections;

public class csFire : MonoBehaviour {

	float deleteTerm;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (transform.forward * 1600f);
	}
	
	// Update is called once per frame
	void Update () {
		deleteTerm += Time.deltaTime;
		if (deleteTerm > 1f) {
			deleteTerm = 0;
			Destroy(this.gameObject);
			return;
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Plane" || col.gameObject.tag == "Human") {
			Debug.Log(col.gameObject.tag);
			Destroy(this.gameObject);
		}
	}
}
