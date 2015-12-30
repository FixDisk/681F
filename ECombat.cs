using UnityEngine;
using System.Collections;

public class ECombat : MonoBehaviour {
	
	public GameObject target;
	
	public float  aTimer;
	public float  coolDown;
	
	void Start () {
		
		aTimer = 0;
		coolDown = 1.0f;
		
	}
	
	
	void Update () {
		
		if (aTimer > 0)
			aTimer -= Time.deltaTime;
		
		if (aTimer < 0)
			aTimer = 0;
			
			if(aTimer == 0)
			{
				
				Attack();
				aTimer = coolDown;
				
			}
	}
	
	private void Attack()
	{
		float eDistance = Vector3.Distance(target.transform.position, transform.position);
		
		Vector3 dir = (target.transform.position - transform.position).normalized;
		
		float direction = Vector3.Dot (dir, transform.forward);
		Debug.Log (direction);
		
		if(eDistance < 2.6f)
		{
			if(direction > 0)
			{

				PHealth eh = (PHealth)target.GetComponent("PHealth");
				eh.CurrentHealth (-10);

			}
		}
	}
}