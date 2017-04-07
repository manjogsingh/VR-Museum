using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour {

	public MovieTexture movie;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().material.mainTexture=movie;
		//MovieTexture movie=(MovieTexture)gameObject.GetComponent<Renderer>().material.mainTexture;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(movie.isPlaying);
	}
	public void Play()
	{
		Debug.Log("lol");
		Debug.Log(movie.isPlaying);
		movie.Play();
	}
}
