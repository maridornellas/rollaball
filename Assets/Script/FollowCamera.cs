//libraries
using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	// Use this for initialization

	public GameObject target; //view target object
	Vector3 offset; //position relative to our view target

	void Start () 
	{
		//compute the offset relative to our target
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = target.transform.position + offset;
	}
}
