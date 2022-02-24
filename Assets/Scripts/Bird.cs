using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour {


    //Velocidad del movimiento 
    public float speed = 8;
    //Fuerza del salto
    public float force = 300;

    // Start is called before the first frame update
    void Start() {
        //Velocidad hacia la derecha del pájaro
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update() {
        //Salto del pájaro
        if (Input.GetKeyDown(KeyCode.Space) ||/*Detección de teclas de teclado*/
            (Input.touchCount>0&&Input.GetTouch(0).phase == TouchPhase.Began) || //*Detección de toque en pantalla del movil*//
            Input.GetMouseButtonDown (0) /*Detección de click en el ratón*/
             ) {
 GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }
    }
    void OnCollisionEnter2D(Collision2D collision) {
        //Restart Level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

}




