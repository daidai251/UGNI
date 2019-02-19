using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}

    public void StartGameButton() {
        EditorSceneManager.LoadScene("Game");

        //EditorSceneManager.LoadLevel
        
    }

    //public void StarGameLoad(string SceneName) {
    //    Application.loadedLevelName();//已经弃用
    //}


}
