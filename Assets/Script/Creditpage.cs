using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditpage : MonoBehaviour
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
    
    public void Button_BackHome()
    {
        SceneManager.LoadScene("Home");
        Debug.Log("aaaaaaaaaaaaaaaaaaaaaa");
    }
    public void Button_BackStorage()
    {
        SceneManager.LoadScene("Storage");
        Debug.Log("aaaaaaaaaaaaaaaaaaaaaa");
    }

    public void Button_FinishFood()
    {
        SceneManager.LoadScene("story_end");
    }

    public void Button_story_end()
    {
        SceneManager.LoadScene("Yousafe");
    }

    public void Button_CutsOne()
    {
        SceneManager.LoadScene("scene_start_02");
    }
    public void Button_CutsTwo()
    {
        SceneManager.LoadScene("scene_start_03");
        Debug.Log("aaaaaaaaaaaaaaaaaaaaaa");
    }
    public void Button_CutsThree()
    {
        SceneManager.LoadScene("scene_start_04");
    }
    public void Button_CutsFour()
    {
        SceneManager.LoadScene("Storage");
    }

}
