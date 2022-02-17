using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

  void Update () {

      /* Añade en el método Update */

//Si pulsa la tecla I vuelve al inicio
if (Input.GetKeyDown(KeyCode.I)){
  //Cargo la escena de Inicio
  SceneManager.LoadScene("Inicio");
}

    //Si pulsa la tecla P o hace clic izquierdo empieza el juego
    if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButton(0)){
      //Cargo la escena de Juego
      SceneManager.LoadScene("Juego");
    }
  }
}