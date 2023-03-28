using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cet : MonoBehaviour
{
    public TMP_Text Enemy;

    public TMP_Text Boss;

    private GameObject[] Enemycet;

    private GameObject[] Bosscet;

    private int counter;

    void Update()
    {
        Enemycet = GameObject.FindGameObjectsWithTag("Enemy");
        Enemy.text = Enemycet.Length.ToString();
        Bosscet = GameObject.FindGameObjectsWithTag("Boss");
        Boss.text = Bosscet.Length.ToString();
    }
}
