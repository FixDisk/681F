using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent (typeof(BoxCollider))]
public class QuestO : MonoBehaviour {
	
	public static QuestO Instance;
	
	public string ObjectiveDone;

	public string QuestDescription;

	public List<QObj> Objectives = new List<QObj>();
	
	public bool IsComplete;
	public bool IsInProgress;

	public QuestO CurrentQuest;
	public QObj CurrentObjective;
	
	public QuestO Past;
	public QuestO Next;
	
	public Transform Transform;
	
	void Awake ()
	{
		
		Instance = this;
		
	}
	
	void Start () {
		
		gameObject.SetActive (CanPlay ());
		
		Transform = transform;
		
	}
	
	public bool CanPlay()
		
	{
		
		if(!IsComplete)
			
		{
			
			if(Past != null)
				
			{
				
				if(Past.IsComplete)
					return true;
				else
					return false;
				
			}
			
			return true;
		}
		
		else
			
		{
			
			return false;
			
		}
		
	}
	
	public void OnStartQuest()
	{
		
		IsInProgress = true;
		IsComplete = false;
		CurrentQuest = this;
		CurrentObjective = Objectives [0];

		GUIEd.Instance.ObjectiveName.gameObject.SetActive (true);
		GUIEd.Instance.ObjectiveDescription.gameObject.SetActive (true);
		GUIEd.Instance.ObjectiveDone.gameObject.SetActive (false);

		GUIEd.Instance.ObjectiveDone.text = ObjectiveDone;
		GUIEd.Instance.ObjectiveName.text = CurrentObjective.ObjectiveName;
		GUIEd.Instance.ObjectiveDescription.text = CurrentObjective.ObjectiveDescription;
		
	}

	void Update () {
		
	}
	
	void OnTriggerEnter(Collider col)
	{
		
		if(CanPlay())
		{
			if(!IsInProgress && !IsComplete)
				OnStartQuest();
		}
		
	}
}