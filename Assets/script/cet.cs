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

    public GameObject strelka;

    public GameObject strelka1;

    public Transform player;

    private int counter;

    public strelrf strelrf;

    /*void Awake()
    {
        Enemycet = GameObject.FindGameObjectsWithTag("Enemy");
        Bosscet = GameObject.FindGameObjectsWithTag("Boss");
        foreach(var i in Enemycet.Length.ToString())
        {
            Instantiate(strelka,player.position,player.rotation,player.transform);
        }
        foreach(var i in Bosscet.Length.ToString())
        {
            Instantiate(strelka1,player.position,player.rotation,player.transform);
        }
    }*/

    void Update()
    {
        Enemycet = GameObject.FindGameObjectsWithTag("Enemy");
        Enemy.text = Enemycet.Length.ToString();
        Bosscet = GameObject.FindGameObjectsWithTag("Boss");
        Boss.text = Bosscet.Length.ToString();
        if(!(GameObject.Find("Strelka(Clone)")) && !(GameObject.Find("Strelka1(Clone)")) && GameObject.FindGameObjectWithTag("Enemy"))
        {
            foreach(var i in Enemycet)
            {
                Instantiate(strelka,player.position,player.rotation,player.transform);
                print(8);
            }
            foreach(var i in Bosscet)
            {
                Instantiate(strelka1,player.position,player.rotation,player.transform);
                print(9);
            }
        }
    }
}
