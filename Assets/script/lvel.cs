using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lvel : MonoBehaviour
{
    public int levl = 1;

    public pawpaw pawpaw;

    public player player;

    public TMP_Text znalvl;

    void Start()
    {
        znalvl = GetComponent<TMP_Text>();
    }

    public void lvelup()
    {
        levl+=1;
        znalvl.text = levl.ToString();
        pawpaw.upgrat((int)levl);
        player.upgrat((int)levl);
    }
}
