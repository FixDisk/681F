using UnityEngine;
using System.Collections;

public class Training : MonoBehaviour {

	void Start () {
	
	}
	

	void Update () {

	}

	void OnTriggerExit()
	{
	
		GUIEd.Instance.Stay.gameObject.SetActive (true);

		Application.LoadLevel ("OngalLqto");

	}

}
