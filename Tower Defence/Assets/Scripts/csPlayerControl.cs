using UnityEngine;
using System.Collections;

public class csPlayerControl : MonoBehaviour {

	public Transform Bullet,Cam,To;
	float rotationSpeed = 10f,rotationX,rotationY;
	// Use this for initialization
	void Start () {
		To = Cam.FindChild ("To").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Instantiate(Bullet, To.position , To.rotation);
		}
		rotationX = Input.GetAxis ("Mouse X") * rotationSpeed;
		rotationY = Input.GetAxis ("Mouse Y") * rotationSpeed;
		transform.Rotate (Vector3.up * rotationX);
		Cam.Rotate (Vector3.right * -rotationY);

		transform.position += transform.forward * Input.GetAxis ("Vertical") * Time.deltaTime + transform.right * Input.GetAxis ("Horizontal") * Time.deltaTime;
	}
}
