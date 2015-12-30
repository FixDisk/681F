using UnityEngine;
using System.Collections;

public class QObj : MonoBehaviour {

	public static QObj Instance;
	
	public ObjectiveType Type;

	public string ObjectiveName;
	public string ObjectiveDescription;
	public string ObjectiveDone;

	public QObj CurrentObjective;
	
	public float GoDistance;
	
	public bool IsComplete = false;
	
	Transform _trans;

	void OnTriggerEnter ()
	{

		QuestO.Instance.IsInProgress = false;
		IsComplete = true;
		QuestO.Instance.CurrentQuest = null;

		GUIEd.Instance.ObjectiveName.gameObject.SetActive (false);
		GUIEd.Instance.ObjectiveDescription.gameObject.SetActive (false);
		GUIEd.Instance.ObjectiveDone.gameObject.SetActive (true);
	}

	void Awake ()
	{
		
		Instance = this;
		
	}
	
	void Start () {
		
		_trans = transform;
		
	}
	
	void Update () {
		
		if (QuestO.Instance.CurrentQuest != null) 
		{
			if (CurrentObjective == this) {
				
				switch(Type) {
					
				case ObjectiveType.Go:
					float dista = Vector3.Distance (_trans.position, QuestO.Instance.Transform.position);
					if (dista <= GoDistance)
						IsComplete = true;
					break;
					
				}
			}
		}
	}
}

public enum ObjectiveType
{
	
	Go,
	Kill,
	Collect
	
}