using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cet : MonoBehaviour
{
    [SerializeField] private TMP_Text Enemy;

    [SerializeField] private TMP_Text Boss;

    private GameObject[] Enemycet;

    private GameObject[] Bosscet;

     private GameObject[] Scrapcet;

    [SerializeField] private GameObject strelka;

    [SerializeField] private GameObject strelka2;

    [SerializeField] private Transform player;

    [SerializeField] private strelrf strelrf;

    void Update()
    {
        Enemycet = GameObject.FindGameObjectsWithTag("Enemy");
        Enemy.text = Enemycet.Length.ToString();
        Bosscet = GameObject.FindGameObjectsWithTag("Boss");
        Boss.text = Bosscet.Length.ToString();
        Scrapcet = GameObject.FindGameObjectsWithTag("Scrap");
        if(!(GameObject.Find("Strelka(Clone)")) && (GameObject.FindGameObjectWithTag("Enemy") || GameObject.FindGameObjectWithTag("Boss")))
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
        if(!(GameObject.Find("Strelka 2(Clone)")) && !(GameObject.FindGameObjectWithTag("Enemy")) && !(GameObject.FindGameObjectWithTag("Boss")))
        {
            foreach(GameObject i in Scrapcet)
            {
                strelka2.GetComponent<strelrf>().Enemy(i);
                Instantiate(strelka2,player.position,player.rotation,player.transform);
            }
        }
    }
}
