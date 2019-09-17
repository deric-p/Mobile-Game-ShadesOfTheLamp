using UnityEngine;
using System.Collections;

public class background_size : MonoBehaviour {

	float cameralength  = 0.563f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 newscale = transform.localScale;
		newscale.x = (cameralength)*(Camera.main.aspect);
		transform.localScale = newscale;
	}
}
