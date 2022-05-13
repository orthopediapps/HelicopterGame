using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update

    private void Start()
    {

    }
    public void Update()
    {

    }
    public void NewScene()
    {
        SceneManager.LoadScene(1);

    }
    public void InstructionsButton()
    {
        SceneManager.LoadScene(2);
    }

    public void TitleScene()
    {
        SceneManager.LoadScene(0);
}
    public void ExitAppButton()
    {
# if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
