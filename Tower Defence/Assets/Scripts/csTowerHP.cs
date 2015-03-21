using UnityEngine;
using System.Collections;

public class csTowerHP : MonoBehaviour {


	int HP=300;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (HP <= 0) {
			print("GameOver");
			Destroy(this.gameObject);
			return;
		}
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Bullet" && HP>0) {
			HP--;
		}
	}
}
