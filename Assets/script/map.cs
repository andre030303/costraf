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
    }

    public void star2()
    {
        SceneManager.LoadScene(3);
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
        if (Input.GetKey(KeyCode.Tab) && !(GameObject.FindGameObjectWithTag("Enemy")))
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
