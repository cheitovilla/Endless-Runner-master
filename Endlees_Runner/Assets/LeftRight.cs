using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour {
    public float speed = 10.0F;
    public bool mov;
    public Stop stop;
    // Use this for initialization
    void Start () {
        mov = true;
	}
	//MOVIMIENTO DEL PLAYER
	// Update is called once per frame
	void Update () {
        if (stop.pause == true)
        {
            return;
        }
        else
        {
            Limit(mov);
        }
        


    }

    public void Limit(bool mov)
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;

        if (transform.position.x < 2.2 && Input.GetAxis("Horizontal") >= 0)
        {
            
            transform.Translate(translation, 0, 0); //movelo
        }
        else
        {
            transform.Translate(0, 0, 0); //NOmovelo
        }

        if (transform.position.x > -2.2 && Input.GetAxis("Horizontal") <= 0)
        {
            transform.Translate(translation, 0,0); //movelo
        }
        else
        {
            transform.Translate(0, 0, 0); //NOmovelo
        }

    }


}
