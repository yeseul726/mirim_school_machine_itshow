﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class go_prev : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Click(){
		SceneManager.LoadScene (7);
	}
}
