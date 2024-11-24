using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Start()
    {
       
        SetSpellName("Fire Spell");
        SetManaCost(150);
        SetPower(300);
        SetEffect("You has create a big fireBall but you can't handdle it... \n you try to throw the fire ball" +
            $"and it does {this.GetPower()} of damage but you get hurt and lost 100 life points");
    }
}
