using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnStart()
    {
        //if (Input.GetKeyDown("joystick button 0"))
        //{
        SceneManager.LoadScene("SampleScene");
        //}
    }

    public void OnEnd()
    {
        //if (Input.GetKeyDown("joystick button 0"))
        //{
        SceneManager.LoadScene("End");
        //}
    }

    public void OnTitle()
    {
        //if (Input.GetKeyDown("joystick button 0"))
        //{
        SceneManager.LoadScene("Title");
        //}
    }
}
