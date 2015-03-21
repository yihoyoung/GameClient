using UnityEngine;
using System.Collections;

public class csEnemyCreate : MonoBehaviour {

	public Transform Enemy;
	float CreateTerm , EnemyNum;
	public float TotalNum;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (TotalNum < 50) {
			CreateTerm += Time.deltaTime;
			if (CreateTerm > 3f) {
				CreateTerm = 0f;
				EnemyNum = 0;
				while (EnemyNum<3f) {
					Instantiate (Enemy, this.transform.position, Quaternion.identity);
					EnemyNum++;
					TotalNum++;
				}
			}
		}
	}
}
