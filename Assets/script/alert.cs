using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class alert : MonoBehaviour
{
    [SerializeField] private float time;

    [SerializeField] private GameObject enemy;

    [SerializeField] private bool one = true;

    [SerializeField] private TMP_Text timer;

    [SerializeField] private cet cet;

    public void oneee()
    {
        one = false;
    }

    public void scet()
    {
        time = 60;
        one = true;
    }

    void Update()
    {
        if(time >= 0 && one)
        {
            time -= Time.deltaTime;
            timer.text = Mathf.RoundToInt(time).ToString();
        }
        if(time <= 0 && one)
        {
            Instantiate(enemy);
            one = false;
            cet.perecet();
        }
    }
}
