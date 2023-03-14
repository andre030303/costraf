using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvel : MonoBehaviour
{
    public int level;

    public Slider slider;

    void Update()
    {
        level = (int)slider.value;
    }
}
