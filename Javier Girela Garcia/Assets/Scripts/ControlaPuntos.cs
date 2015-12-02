using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControlaPuntos : MonoBehaviour {

    public Text texto_puntos;
    public int puntos;

    public void suma_puntos(int puntos_nuevos){
        puntos += puntos_nuevos;
        texto_puntos.text = "" + puntos;
        Debug.Log("" + puntos);
    }
}
