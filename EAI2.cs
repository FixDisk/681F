﻿using UnityEngine;
using System.Collections;

public class EAI2 : MonoBehaviour {

	public Transform target;
	
	public int mSpeed;
	public int rSpeed;
	
	public int maxDist;
	
	private Transform myTransform;
	
	void Awake()
	{

		target = null;
		
		myTransform = transform;
		
		maxDist = 2;
		
	}
	
	void Start () {
		
	}
	
	
	void Update () {
		
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rSpeed * Time.deltaTime);
		
		if(Vector3.Distance(target.position, myTransform.position) > maxDist)
		{
			
			myTransform.position += myTransform.forward * mSpeed * Time.deltaTime;
			
		}
	}
	
	void OnTriggerEnter()
	{
		
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		
		target = go.transform;
		
		FPSC.Instance.targete = GameObject.FindGameObjectWithTag ("Enemy1");
		
	}
	
	void OnTriggerExit()
	{
		
		target = null;
		
		FPSC.Instance.targete = null;
		
	}
	
}
