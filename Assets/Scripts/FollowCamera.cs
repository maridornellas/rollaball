using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public GameObject target; //View target object
	Vector3 offset; // positioj relative to the view target

	// Use this for initialization
	void Start () 
	{
		//compute the offest relative to our target
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		transform.position = target.transform.position + offset;
	}
}
