using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lvel : MonoBehaviour
{
    public int levl;

    public pawpaw pawpaw;

    private player player;

    public TMP_Text znalvl;

    private int HP;

    private int Speed;

    private int Damage;

    void Start()
    {
        player = GetComponent<player>();
    }

    public void HPUP()
    {
        if(levl>0)
        {
            levl-=1;
            HP+=1;
            player.upgrat(HP);
        }
    }
    public void HPDawn()
    {
        if(HP<0)
        {
            levl-=1;
            HP+=1;
            player.upgrat(HP);
        }
    }
    public void SpeedUP()
    {

    }
    public void SpeedDawn()
    {

    }
    public void DamageUP()
    {
        if(levl>0)
        {
            levl-=1;
            Damage+=1;
            pawpaw.upgrat(Damage);
        }
    }
    public void DamageDawn()
    {
        if(HP<0)
        {
            levl+=1;
            Damage-=1;
            pawpaw.upgrat(Damage);
        }
    }

    public void lvelup()
    {
        levl+=1;
        znalvl.text = levl.ToString();
    }
}
