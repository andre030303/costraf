using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map : MonoBehaviour
{
    public GameObject mape;

    public GameObject strelka;

    public void star1()
    {   
        SceneManager.LoadScene(2);
        strelka.SetActive(true);
    }      

    void Update()
    {
        if (!(GameObject.FindGameObjectWithTag("Enemy")) && Input.GetKey(KeyCode.F))
        {
            mape.SetActive(true);
        }
        else
        {
            mape.SetActive(false);
        }
        
    }
}
