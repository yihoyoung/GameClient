using UnityEngine;
using System.Collections;

public class csEnemyAI : MonoBehaviour {


	Vector3 TargetPosition, playerDestination;
	NavMeshAgent playerAgent;
	public Transform Tower;
	public Transform Bullet, EnemyCreater;
	int HP;
	// Use this for initialization
	void Start () {
		playerAgent = GetComponent<NavMeshAgent> ();
		playerDestination = playerAgent.destination;
		HP = 3;

	}
	
	// Update is called once per frame
	void Update () {
		if (HP <= 0) {
			print("Die");
			EnemyCreater.GetComponent<csEnemyCreate>().TotalNum--;
			Destroy(this.gameObject);
			return;
		}
		if (Vector3.Distance (this.transform.position, Tower.position) > 10f) {
			playerAgent.SetDestination (Tower.position);
		} else {

			Attack(Tower);
		}
	}
	void Attack(Transform target){
		transform.LookAt(target);
		Instantiate (Bullet, transform.FindChild("To").position, Quaternion.identity);
	}

	void OnCollisionEnter(Collision col){
		//Debug.Log(col.gameObject.tag);
		if (col.gameObject.tag == "Bullet") {
			HP--;
		}
	}


}
