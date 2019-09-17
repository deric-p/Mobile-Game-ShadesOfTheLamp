using UnityEngine;
using System.Collections;



public class desolateoasis : MonoBehaviour {

	private Animator desolate;
	bool active = true;

	// Use this for initialization
	void Start () {
		desolate = GetComponent<Animator> ();
	}
	void Awake(){
		
		StartCoroutine ("WaitOneSecond");
		
		
	}
	IEnumerator WaitOneSecond(){
		
		while (active) {

			yield return new WaitForSeconds (1);
			desolate.SetInteger ("do", Random.Range (0, 10));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
