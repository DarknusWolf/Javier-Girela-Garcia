using UnityEngine;
using System.Collections;

public class Naves_enemigas : MonoBehaviour {

    public float Velocidad = 10f; //Es la fuerza con la que se desplazara el propio personaje, que se puede editar desde fuera.
    Rigidbody2D rg; //Es el Rigidbody en el que se le aplicara las fuerzas correspondientes


    // Use this for initialization
    void Start(){
        rg = GetComponent<Rigidbody2D>(); //Se coge el Rigidbody2D de la propia nave
    }

    // Update is called once per frame
    void Update(){
        rg.velocity = new Vector2(0, -Velocidad);
    }
}
