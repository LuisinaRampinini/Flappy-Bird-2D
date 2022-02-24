using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    //Movimiento arriba/abajo de las tuberías (0 = no movimiento de la tubería)
    public float speed = 0;
    //Tiempo de cambio de movimiento para las tuberías
    public float switchTime = 2;

    private float distanceToDestroy = 32;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        //Invocamos el metodo cada x segundos
        InvokeRepeating("SwitchMovement", 0, switchTime);
    }

    void SwitchMovement()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }


    void Update()
    {
        float xcam = Camera.main.transform.position.x;
        float xpipe = this.transform.position.x;
        if (xcam > xpipe + distanceToDestroy)
        {
            Destroy(this.gameObject);
        }

    }

}



