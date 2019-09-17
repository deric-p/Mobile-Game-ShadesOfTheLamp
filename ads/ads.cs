using UnityEngine;
using System.Collections;
 using UnityEngine.Advertisements;

public class ads : MonoBehaviour {

	int victory;
	int defeat;
	bool check;
	GameObject levels;
	GameObject zerovictory;
	GameObject zerodefeat;
	GameObject defeat1;
	GameObject background;
	
	public static ads instance = null;
	// Use this for initialization
	void Start () {

		victory = 0;
		defeat = 0;
		
		check = false;	
	}
	void Awake(){

		//Check if there is already an instance of SoundManager
            if (instance == null) {
                //if not, set it to this.
                instance = this;
            }
            //If instance already exists:
            else if (instance != this){
                //Destroy this, this enforces our singleton pattern so there can only be one instance of SoundManager.
                Destroy (gameObject);
            }
		
		Advertisement.Initialize ("1027042");
		levels = GameObject.FindGameObjectWithTag("loading").gameObject;
		background = GameObject.FindGameObjectWithTag("backgrounds").gameObject;

		if(levels != null){
			zerovictory = GeneralControls.ReturnNumber(levels,"victory");
			zerodefeat = GeneralControls.ReturnNumber(levels,"zero");
			defeat1 = GeneralControls.ReturnNumber(levels,"defeated");
		}
		
		DontDestroyOnLoad (gameObject);
	}
	void ResetEverything(){

		levels = GameObject.FindGameObjectWithTag("loading").gameObject;

		if(levels != null){
			zerovictory = GeneralControls.ReturnNumber(levels,"victory");
			zerodefeat = GeneralControls.ReturnNumber(levels,"zero");
			defeat1 = GeneralControls.ReturnNumber(levels,"defeated");
		}
		check = false;
		
	}
	// Update is called once per frame
	void Update () {
		if(GameObject.FindGameObjectWithTag("backgrounds").gameObject !=null){

			if(background != GameObject.FindGameObjectWithTag("backgrounds").gameObject){
				
				ResetEverything();
				background = GameObject.FindGameObjectWithTag("backgrounds").gameObject;
			}
		}

		if((zerovictory!=null)&&
			(zerodefeat!=null)&&
			(defeat1!=null)){

			if((zerovictory.activeSelf == true)&&
			   (!check)){

			   	check = true;
			   	victory++;
			}
			if((zerodefeat.activeSelf == true)&&
			   (!check)){

			   	check = true;
			   	defeat++;
			}
			if((defeat1.activeSelf == true)&&
			   (!check)){

			   	check = true;
			   	defeat++;
			}
			if(victory >=5){
				if(Advertisement.IsReady()){
					Advertisement.Show();
					victory = 0;
					defeat = 0;
				}
			}
			if(defeat >=5){
				if(Advertisement.IsReady()){
					Advertisement.Show();
					victory = 0;
					defeat = 0;
				}
			}
			if((victory >=2)&&(defeat >= 3)){
				if(Advertisement.IsReady()){
					Advertisement.Show();
					victory = 0;
					defeat = 0;
				}
			}
			if((victory >=1)&&(defeat >= 4)){
				if(Advertisement.IsReady()){
					Advertisement.Show();
					victory = 0;
					defeat = 0;
				}
			}
			if((victory >=3)&&(defeat >= 2)){
				if(Advertisement.IsReady()){
					Advertisement.Show();
					victory = 0;
					defeat = 0;
				}
			}
			if((victory >=4)&&(defeat >= 1)){
				if(Advertisement.IsReady()){
					Advertisement.Show();
					victory = 0;
					defeat = 0;
				}
			}


		}
	
	}
}
