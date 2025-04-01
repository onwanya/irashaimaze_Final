using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void Button_Start()
    {
        SceneManager.LoadScene("scene_start_01");
    }

    public void Button_Restart()
    {
        SceneManager.LoadScene("Storage");
    }

    public void Button_Credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Button_Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

}
