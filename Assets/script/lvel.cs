using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvel : MonoBehaviour
{
    public Slider slider;

    public float levl = 1;

    public pawpaw pawpaw;

    public player player;

    void Start()
    {
        levl=slider.value;
    }

    void Update()
    {
        if(slider.value>levl)
        {
            levl=slider.value;
            pawpaw.upgrat((int)levl);
            player.upgrat((int)levl);

        }
    }
}
