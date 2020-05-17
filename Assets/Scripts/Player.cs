	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class Player : MonoBehaviour {

	public SceneController sceneController;

	public AudioClip Sonido = null;		
	public AudioClip Winner = null;
	public float	 Volumen = 1.0f;
	protected Transform Posicion = null;

	public static int score=0;

	private Rigidbody2D rb;
	public float speed = 1;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		Posicion = transform;	
		score = 0;
			
	}

	// Update is called once per frame
	void Update () {
		//GetMouseButtonDown => Touch
		if (Input.GetMouseButtonDown (0)) {
			rb.velocity = Vector2.up * speed;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision) {
	if(Sonido) AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);

	sceneController.YouLose ();			
	}

	private void OnTriggerEnter2D(Collider2D collaider) {
		Debug.Log ("You've win one point"+ score);
		score=score+1;
		if (score>6){
			sceneController.YouWin (); 
			if(Winner) AudioSource.PlayClipAtPoint(Winner, Posicion.position, Volumen);
			}
		
		
	}



	}