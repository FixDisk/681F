using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIEd : MonoBehaviour {
	
	public static GUIEd Instance;
	
	public Text ObjectiveDone;
	public Text ObjectiveName;
	public Text ObjectiveDescription;
	public Text Stay;

	void Awake ()
	{
		
		Instance = this;
		
	}
	
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}
}