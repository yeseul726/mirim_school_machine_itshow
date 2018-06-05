using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class start_waytoplay : MonoBehaviour {
    void Awake()
    {
    }

    /*public void StartButton()
    {
        Invoke("startgame", .5f);
    }*/
	public void Click()
    {
		//SceneManager.LoadScene(2);
		start.mission_num = Random.Range (1, 4);
		//1 : summer 2 : auttum 3 : winter
		//arrow_move.season = mission_num;
		Debug.Log (start.mission_num);
		if (start.mission_num == 1) {
			SceneManager.LoadScene ("mission_autumn");
		} else if (start.mission_num == 2) {
			SceneManager.LoadScene ("mission_winter");
		} else if (start.mission_num == 3) {
			SceneManager.LoadScene ("mission_summer");
		}
    }
}
