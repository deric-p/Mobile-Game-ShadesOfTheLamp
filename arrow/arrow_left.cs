using UnityEngine;
using System.Collections;

public class arrow_left : MonoBehaviour {

	float arrow_positionx = 8f;
	float cameralength  = 0.51f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 arrow_position = transform.localPosition;
		arrow_position.x = (Camera.main.aspect)*(arrow_positionx);
		transform.localPosition = arrow_position;

		Vector3 arrowscale = transform.localScale;
		arrowscale.x = (cameralength)*(Camera.main.aspect);
		arrowscale.y = (cameralength)*(Camera.main.aspect);
		transform.localScale = arrowscale;
	
	}
}
