using UnityEngine;
using System.Collections;

public class Mech : MonoBehaviour {
	
	void Start () {
	
	}

	void Update () {
	
		if(Input.GetButtonDown("Fire1"))
		{

			GetComponent<Animation>().Play("Cube|CubeAction");

		}

	}
}
