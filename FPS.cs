using UnityEngine;
using System.Collections;

public class FPS : MonoBehaviour {

	public static FPS Instance;

	public float movementSpeed = 5.0f;
	public float mouseSensitivity = 5.0f;
	public float jSpeed = 10.0f;

	float VertR = 0;
	public float UDRange = 60.0f;

	float vVel = 0;

	public Transform Transform;

	void Awake ()
	{
		
		Instance = this;
		
	}

	void Start () {

		Transform = transform;

		Cursor.visible = false;
	
	}

	void Update () {

		CharacterController cc = GetComponent<CharacterController> ();

		float rotLR = Input.GetAxis ("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotLR, 0);

		VertR -= Input.GetAxis("Mouse Y") * mouseSensitivity;
		VertR = Mathf.Clamp (VertR, -UDRange, UDRange);
		Camera.main.transform.localRotation = Quaternion.Euler(VertR, 0, 0);

		float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
		float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

		vVel += Physics.gravity.y * Time.deltaTime;
		if (cc.isGrounded && Input.GetButtonDown ("Jump")) {
			vVel = jSpeed;
		} 

		Vector3 speed = new Vector3 (sideSpeed, vVel, forwardSpeed);

		speed = transform.rotation * speed;

		cc.Move (speed * Time.deltaTime);

		if(Input.GetKeyDown(KeyCode.B))
		{

			Vector3 position = transform.position;
			position.z = 223.9f;
			position.y = 1.3f;
			position.x = 896.5f;
			transform.position = position;

		}
	}
}
