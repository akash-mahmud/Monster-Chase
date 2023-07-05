using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    private GameObject[] charecters;

    private int _charecterIndex;
    public int CharecterIndex {
        get{
            return _charecterIndex;
        }
        set{
            _charecterIndex = value;
        }
    }
private void Awake(){
    if (instance== null)
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }else{
        Destroy(gameObject);
    }
}
private void OnEnable(){
    print("Enabled Called");
    SceneManager.sceneLoaded += OnLevelFinishedLoading;
        }

private void OnDisable(){
        print("disabled Called");

    SceneManager.sceneLoaded -= OnLevelFinishedLoading;

}

    
void OnLevelFinishedLoading(Scene scene , LoadSceneMode mode){
    if (scene.name=="GamePlay")
    {
        print("index"+charecters[CharecterIndex]);
        Instantiate(charecters[CharecterIndex]);
    }
}


}
