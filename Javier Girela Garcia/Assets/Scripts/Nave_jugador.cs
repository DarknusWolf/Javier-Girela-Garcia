using UnityEngine;
using System.Collections;

public class Nave_jugador : MonoBehaviour{

    public float Fuerza = 10f; //Es la fuerza con la que se desplazara el propio personaje, que se puede editar desde fuera.
    public float Fuerza_laser = 10f;
    public GameObject Laser;
    Rigidbody2D rg; //Es el Rigidbody en el que se le aplicara las fuerzas correspondientes
    Rigidbody2D rg_laser;

    // Use this for initialization
    void Start(){
        rg = GetComponent<Rigidbody2D>(); //Se coge el Rigidbody2D de la propia nave
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){ //Mover Izquierda con la A
            rg.velocity = new Vector2(-Fuerza, 0); //Se añade la Fuerza hacia la izquierda
        }

        if (Input.GetKey(KeyCode.D)){ //Mover Derecha con la D
            rg.velocity = new Vector2(Fuerza, 0); //Se añade la Fuerza hacia la derecha
        }

        if ((Input.GetKeyUp(KeyCode.D)) || (Input.GetKeyUp(KeyCode.A))) { //Con este if controlamos cuando el jugador suelta uno de los dos botones especificados
            rg.velocity = new Vector2(0, 0); //Se le añade una fuerza 0 para frenar al personaje
        }

        if (Input.GetKeyDown(KeyCode.Space)){ //Dispara laser con el espacio

            GameObject nuevo_proyectil = (GameObject) Instantiate(Laser, transform.position, transform.rotation);
            rg_laser = nuevo_proyectil.GetComponent<Rigidbody2D>();
            rg_laser.AddForce(new Vector2 (0, Fuerza_laser));
        }

    }
}
