using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map : MonoBehaviour
{
    public GameObject mape;

    public GameObject strelka;

    public GameObject Text;

    public void star1()
    {
        SceneManager.LoadScene(2);
        strelka.SetActive(true);
    }

    public void star2()
    {
        SceneManager.LoadScene(3);
        strelka.SetActive(true);
    }


    void Update()
    {

        if (!(GameObject.FindGameObjectWithTag("Enemy")))
        {
            Text.SetActive(true);
        }
        if (Input.GetKey(KeyCode.M) && !(GameObject.FindGameObjectWithTag("Enemy")))
        {
            mape.SetActive(true);
            Text.SetActive(false);
        }
        else
        {
            mape.SetActive(false);
        }
    }
}
