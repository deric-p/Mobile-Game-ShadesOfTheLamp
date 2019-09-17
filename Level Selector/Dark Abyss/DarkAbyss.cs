using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DarkAbyss : MonoBehaviour {

	private GameObject one;
	
	
	
	private GameObject levelz;
	private Animator ones;
	
	private GameObject temp;
	public GUIText loading;
	private GameObject loader;
	private GameObject [] loaderArray;
	private GameObject arrow_right;

	int loadprogress = 0;
	

	// Use this for initialization
	void Start () {
		Sound.instance.da();
		StartCoroutine("delaystart");
	}

	void Awake(){

		loaderArray = GameObject.FindGameObjectsWithTag("loading");

		levelz = GameObject.FindGameObjectWithTag("levels").gameObject;
		

		one = GeneralControls.ReturnNumber(levelz,"one");

	
		
		arrow_right = transform.FindChild("arrow_right").gameObject;
		loader = transform.FindChild("loadbar").gameObject;


		ones = one.GetComponent<Animator>();
		
		


		
	}
	
	
	
	// Update is called once per frame
	void Update () {

		if(Input.touchCount > 0){

			if(Input.GetTouch(0).phase == TouchPhase.Began){

				temp = GeneralControls.checkTouch(Input.GetTouch(0).position);

			}
		}

		if(Input.GetMouseButtonDown(0)){

			temp = GeneralControls.checkTouch(Input.mousePosition);

		}
		if(temp == one){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level30story"));

		}
		
		
		if(temp == arrow_right){
			temp = null;
			Sound.instance.buttonclick();
			StartCoroutine(loadinglevel("LevelSelectorTwilightMist"));
		}
	



	}
	  IEnumerator loadinglevel(string level){

	  	loader.SetActive(true);
	  	levelz.SetActive(false);
	  	
	  	arrow_right.SetActive(false);
	  

	  	for(int i=0;i<loaderArray.Length;i++){
	  		loaderArray[i].SetActive(false);
	  	}
	  	loading.fontSize = (Screen.width)/19;
	  	loading.text = "Loading "+ loadprogress +"%";
	  	AsyncOperation async = SceneManager.LoadSceneAsync(level);

	  	while(!async.isDone){
	  		loadprogress = (int)(async.progress * 100);
	  		loading.text = "Loading "+ loadprogress +"%";
	  		yield return null;
	  	}


	  }
	  IEnumerator delaystart(){
	  	if(PlayerPrefs.GetInt("level30complete") != 1){
			one.SetActive(true);
			
		}
		if(PlayerPrefs.GetInt("level30complete") == 1){
			one.SetActive(true);
			ones.SetBool("complete",true);
				
		}
		
		
		yield return new WaitForSeconds(0.2f);
	  }

}