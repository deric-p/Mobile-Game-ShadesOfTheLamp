using UnityEngine;
using System.Collections;

public class position : MonoBehaviour {

	float level_scale = 0.55f;
	float cameralength =-0.30f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 position = transform.localPosition;
		position.x = (cameralength)*(Camera.main.aspect);
		transform.localPosition = position;

		Vector3 levelscale = transform.localScale;
		levelscale.x = (level_scale)*(Camera.main.aspect);
		levelscale.y = (level_scale)*(Camera.main.aspect);
		transform.localScale = levelscale;
	
	}
}
