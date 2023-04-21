using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lvel : MonoBehaviour
{
    [SerializeField] private int levl;

    [SerializeField] private pawpaw pawpaw;

    private player player;

    private wasd wasd;

    [SerializeField] private TMP_Text znalvl;

    [SerializeField] private TMP_Text znaHP;

    [SerializeField] private TMP_Text znaSpeed;

    [SerializeField] private TMP_Text znaDamage;

    private int HP;

    private int Speed;

    private int Damage;

    void Start()
    {
        player = GetComponent<player>();
        wasd = GetComponent<wasd>();
    }

    public void HPUP()
    {
        if(levl>0)
        {
            levl-=1;
            HP+=1;
            znaHP.text = HP.ToString();
            player.upgrat(HP);
        }
    }
    public void HPDawn()
    {
        if(HP>0)
        {
            levl+=1;
            HP-=1;
            znaHP.text = HP.ToString();
            player.upgrat(HP);
        }
    }
    public void SpeedUP()
    {
        if(levl>0)
        {
            levl-=1;
            Speed+=1;
            znaSpeed.text = Speed.ToString();
            wasd.upgrat(Speed);
        }
    }
    public void SpeedDawn()
    {
        if(Speed>0)
        {
            levl+=1;
            Speed-=1;
            znaSpeed.text = Speed.ToString();
            wasd.upgrat(Speed);
        }
    }
    public void DamageUP()
    {
        if(levl>0)
        {
            levl-=1;
            Damage+=1;
            znaDamage.text = Damage.ToString();
            pawpaw.upgrat(Damage);
        }
    }
    public void DamageDawn()
    {
        if(Damage>0)
        {
            levl+=1;
            Damage-=1;
            znaDamage.text = Damage.ToString();
            pawpaw.upgrat(Damage);
        }
    }

    public void lvelup()
    {
        levl+=1;
        znalvl.text = levl.ToString();
    }
}
