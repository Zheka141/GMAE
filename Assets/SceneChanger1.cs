using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame

    void Update()
    {

    }

    public void Play()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Exitt()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
