using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public int resistencia;
	public ParticleSystem systemaParticulas;
	//public AudioSource sonido;
	public float yPosicion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RegistrarImpacto(Vector3 puntoImpacto){
        resistencia--;
		//systemaParticulas = systemaParticulas.GetComponent<ParticleSystem> ();
		systemaParticulas.transform.position = puntoImpacto;
		systemaParticulas.Play ();
		//sonido.Play ();
       

		if (gameObject.CompareTag ("PaBajo")) {

			transform.position = new Vector3 (transform.position.x, transform.position.y -1, transform.position.z);
		
			Debug.Log ("elav");
		
		
		}
		if (gameObject.CompareTag ("Recolectable")) {
			transform.position = new Vector3 (transform.position.x, transform.position.y +1, transform.position.z);
		}


        }
    }

