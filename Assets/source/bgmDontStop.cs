using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class bgmDontStop : MonoBehaviour {

	private static bgmDontStop _instance;

	void Awake(){
		/*if (!_instance)
		{
			_instance = this;
		}
		else
		{
			Destroy(this.gameObject);
		}*/ //싱글톤. 이걸 살리면 다시 메인으로 돌아왔을 때 버튼 이벤트가 작동 X

		//DontDestroyOnLoad(transform.gameObject);
		/*if (_instance == null) {
			_instance = this;
		} else if (_instance != this) {
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);*/
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if ((SceneManager.GetActiveScene().name == "mission_summer") || (SceneManager.GetActiveScene().name == "mission_autumn") || (SceneManager.GetActiveScene().name == "mission_winter")) {
			Debug.Log ("destroy");
			GameObject.Destroy (gameObject);
		} else {
			DontDestroyOnLoad (gameObject);
		}
	}
}
