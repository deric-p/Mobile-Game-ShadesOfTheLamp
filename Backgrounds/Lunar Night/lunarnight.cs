using UnityEngine;
using System.Collections;

public class lunarnight : MonoBehaviour {

	private Animator lunar;
	bool active = true;

	// Use this for initialization
	void Start () {
		lunar = GetComponent<Animator> ();
	}
	void Awake(){
		
		StartCoroutine ("WaitOneSecond");
		
		
	}
	
	IEnumerator WaitOneSecond(){
		
		while (active) {

			yield return new WaitForSeconds (1);
			lunar.SetInteger ("ln", Random.Range (0, 20));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
