using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map : MonoBehaviour
{
    public GameObject mape;

    public void star1()
    {   
        SceneManager.LoadScene(2);
    }      

    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            mape.SetActive(true);
        }
        else
        {
            mape.SetActive(false);
        }
        
    }
}
