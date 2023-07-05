using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUiControler : MonoBehaviour
{
      public void Restart(){
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
         public void Home(){
SceneManager.LoadScene("MainMenu");

   }
}
