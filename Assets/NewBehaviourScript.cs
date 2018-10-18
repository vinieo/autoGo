using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	private UnityEngine.AI.NavMeshAgent aa;
	public Transform bb;
	// Use this for initialization
	void Start () {
		aa = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		aa.SetDestination(bb.position);
	}
}
