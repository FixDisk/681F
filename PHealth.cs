using UnityEngine;
using System.Collections;

public class PHealth : MonoBehaviour {

	public int maxHealth = 100;
	public int curHealth = 100;

	public float healthLen;

	void Start () {
	
		healthLen = Screen.width / 2;

	}
	

	void Update () {
	
		CurrentHealth (0);
	}

	void OnGUI()
	{

		GUI.Box(new Rect(10, 10, healthLen, 20), curHealth + "/" + maxHealth);

	}

	public void CurrentHealth (int adj)
	{

		curHealth += adj;

		if (curHealth < 0)
		{
			curHealth = 0;
			Destroy(gameObject);
			Application.LoadLevel ("Ongal");
		}

		if (curHealth > maxHealth)
			curHealth = maxHealth;

		
		if (maxHealth < 1)
			maxHealth = 1;

		healthLen = Screen.width / 2 * (curHealth / (float)maxHealth);

	}

}
