using UnityEngine;
using System.Collections;

public class Intro2 : MonoBehaviour {

	public float timeLeft = 0.6f;
	public float FDuration = 0.5f;
	
	void Start () {
		
		
	}
	
	
	void Update () {
		
		Color myColor = GetComponent<GUIText>().color;
		float ratio = Time.time / FDuration;
		myColor.a = Mathf.Lerp (1, 0, ratio);
		GetComponent<GUIText>().color = myColor;
		
		timeLeft -= Time.deltaTime ;
		
		if(timeLeft < 0)
		{
			Application.LoadLevel ("Ongal");
		}
		
	}
}
