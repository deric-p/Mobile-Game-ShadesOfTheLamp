using UnityEngine;
using System.Collections;

public class darkabyss : MonoBehaviour {

	private Animator dark;
	bool active = true;

	// Use this for initialization
	void Start () {
		dark = GetComponent<Animator> ();
	}
	void Awake(){
		
		StartCoroutine ("WaitOneSecond");
		
		
	}
	IEnumerator WaitOneSecond(){
		
		while (active) {

			yield return new WaitForSeconds (2);
			dark.SetInteger ("da", Random.Range (0, 5));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
