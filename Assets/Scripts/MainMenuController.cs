using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
//    public void Playgame(){
//  int selectedCharecter =   int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
//  GameManager.instance.CharecterIndex = selectedCharecter;
// SceneManager.LoadScene("GamePlay");
//    }
    public void Playgame() {

        int selectedCharacter =
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharecterIndex = selectedCharacter;

        SceneManager.LoadScene("GamePlay");

    }
}
