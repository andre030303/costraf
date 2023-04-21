using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map : MonoBehaviour
{
    [SerializeField] private GameObject mape;

    [SerializeField] private GameObject Text;

    [SerializeField] private GameObject levl;

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

    public bool ControlEnemy()
    {
        return !(GameObject.FindGameObjectWithTag("Enemy")) && !(GameObject.FindGameObjectWithTag("Boss"));
    }


    void Update()
    {

        if (ControlEnemy())
        {
            Text.SetActive(true);
        }
        if (Input.GetKey(KeyCode.M) && ControlEnemy())
        {
            mape.SetActive(true);
            Text.SetActive(false);
        }
        else
        {
            mape.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Tab) && ControlEnemy())
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
