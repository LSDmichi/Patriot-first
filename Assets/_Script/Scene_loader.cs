using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour {
    public string Next_scene;
    public void SceneLoader(string Next_scene) {
        Debug.Log(Next_scene);
        SceneManager.LoadScene(Next_scene);
    }
}