using UnityEngine;
using System.Collections;

public class Nave_jugador : MonoBehaviour
{

    public float Fuerza = 10f;
    Rigidbody2D rg;

    // Use this for initialization
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        { //Mover Izquierda
            rg.velocity = new Vector2(-Fuerza, 0);
        }

        if (Input.GetKey(KeyCode.D))
        { //Mover Derecha
            rg.velocity = new Vector2(Fuerza, 0);
        }

        if ((Input.GetKeyUp(KeyCode.D)) || (Input.GetKeyUp(KeyCode.A)))
        {
            rg.velocity = new Vector2(0, 0);
        }
    }
}
