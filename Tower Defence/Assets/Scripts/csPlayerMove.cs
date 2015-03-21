using UnityEngine;
using System.Collections;

public class csPlayerMove : MonoBehaviour {

	Vector3 TargetPosition, playerDestination;
	NavMeshAgent playerAgent;
	RaycastHit hit;
	Ray ray;
	// Use this for initialization
	void Start () {
		playerAgent = GetComponent<NavMeshAgent> ();
		playerDestination = playerAgent.destination;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast(ray, out hit)){
				if(hit.transform.tag == "Plane"){
					playerAgent.SetDestination(hit.point);
				}
			}
		}
	}
}
