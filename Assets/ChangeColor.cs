using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public Renderer rend;
    public TextMesh textObject;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BlueCube")
        {
            rend.material.color = Color.white;
            textObject.text = "Hmmm. maybe?";
        }
    }
}
