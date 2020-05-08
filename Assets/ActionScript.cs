using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartScene()
	{
		Application.LoadLevel("Scene2");
	}

	public void Options(GameObject window)
	{
		window.SetActive(true);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
