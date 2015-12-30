using UnityEngine;
using System.Collections;

public class FPSC : MonoBehaviour {

	public static FPSC Instance;

	public GameObject targete;

	public float  aTimer;
	public float  coolDown;

	void Awake ()
	{
	
		Instance = this;

	}

	void Start () {
	
		aTimer = 0;
		coolDown = 0.7f;

	}
	

	void Update () {

		if (aTimer > 0)
			aTimer -= Time.deltaTime;

		if (aTimer < 0)
			aTimer = 0;


		if(Input.GetButtonDown("Fire1"))
		{

			if(aTimer == 0)
			{

			Attack();
				aTimer = coolDown;

			}

		}

	}

	private void Attack()
	{
		float eDistance = Vector3.Distance(targete.transform.position, transform.position);

		Vector3 dir = (targete.transform.position - transform.position).normalized;

		float direction = Vector3.Dot (dir, transform.forward);
		Debug.Log (direction);

		if(eDistance < 2.6f)
		{
			if(direction > 0)
			{

		EHealth eh = (EHealth)targete.GetComponent("EHealth");
		eh.CurrentHealth (-10);

			}
		}
	}
}
