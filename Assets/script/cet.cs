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

    public Transform player;

    private int counter;

    public strelrf strelrf;

    void Update()
    {
        Enemycet = GameObject.FindGameObjectsWithTag("Enemy");
        Enemy.text = Enemycet.Length.ToString();
        Bosscet = GameObject.FindGameObjectsWithTag("Boss");
        Boss.text = Bosscet.Length.ToString();
        if(!(GameObject.Find("Strelka(Clone)")) && GameObject.FindGameObjectWithTag("Enemy") || GameObject.FindGameObjectWithTag("Boss"))
        {
            foreach(GameObject i in Enemycet)
            {
                strelka.GetComponent<strelrf>().Enemy(i);
                Instantiate(strelka,player.position,player.rotation,player.transform);
            }
            foreach(GameObject i in Bosscet)
            {
                strelka.GetComponent<strelrf>().Enemy(i);
                Instantiate(strelka,player.position,player.rotation,player.transform);
            }
        }
    }
}
