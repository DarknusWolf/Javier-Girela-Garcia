using UnityEngine;
using System.Collections;

public class Destructor_enemigos : MonoBehaviour {
    
    public int puntos_valor = 1;
    private ControlaPuntos cp;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D objeto){
        if (objeto.tag == "laser_jugador"){
            //cp = objeto.gameObject.GetComponent<ControlaPuntos>();
            //cp.suma_puntos(puntos_valor);
            Destroy(gameObject);
        }

        if (objeto.tag == "destruir"){
            Destroy(gameObject);
        }

        if (objeto.tag == "Player"){
            Destroy(gameObject);
        }
    }
}
