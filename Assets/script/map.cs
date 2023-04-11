using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map : MonoBehaviour
{
    public GameObject mape;

    public GameObject Text;

    public GameObject levl;

    public void star1()
    {
        SceneManager.LoadScene(2);
        mape.SetActive(false);
        levl.SetActive(false);
    }

    public void star2()
    {
        SceneManager.LoadScene(3);
        mape.SetActive(false);
        levl.SetActive(false);
    }


    void Update()
    {

        if (!(GameObject.FindGameObjectWithTag("Enemy")) && !(GameObject.FindGameObjectWithTag("Boss")))
        {
            Text.SetActive(true);
            if (Input.GetKey(KeyCode.M))
            {
                mape.SetActive(true);
                Text.SetActive(false);
            }
            else
            {
                mape.SetActive(false);
            }
            if (Input.GetKey(KeyCode.Tab))
            {
                levl.SetActive(true);
                Text.SetActive(false);
            }
            else
            {
                levl.SetActive(false);
            }
        }
    }
}
