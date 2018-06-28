using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitplayer2 : MonoBehaviour
{

    public int AttackDamage;

    void OnTriggerEnter(Collider other)
    {
        HUD_Manager hudmanager = other.gameObject.GetComponent<HUD_Manager>();
        if (hudmanager != null)
        {
            hudmanager.UpdateHealth(AttackDamage);
        }

    }
}