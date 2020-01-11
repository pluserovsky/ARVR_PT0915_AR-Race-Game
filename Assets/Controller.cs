using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

	private Animation anim;
	//public Score score;
	public Text scoreText;


	private Rigidbody rb;
	public float Speed = 90.0f;
	public float rotationSpeed = 45.0f;

	private float referenceYPosition;
	// Use this for initialization
	void Start()
	{
		Resources.UnloadUnusedAssets();
		//anim = GetComponent<Animation> ();
		rb = GetComponent<Rigidbody>();
		scoreText = GameObject.Find("Scoretext").GetComponent<Text>();
		referenceYPosition = transform.localPosition.y;

	}

	// Update is called once per frame
	void Update()
	{

		float x = CrossPlatformInputManager.GetAxis("Horizontal");
		float y = CrossPlatformInputManager.GetAxis("Vertical");



		transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
		transform.Translate(0, 0, y * Time.deltaTime * Speed);

	}
}