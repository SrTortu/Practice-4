using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSpell : Spell
{
    private void Start()
    {

        SetSpellName("Water Spell");
        SetManaCost(300);
        SetPower(150);
        SetEffect("You has create a water wave ... \n" +
            $"and it does {this.GetPower()} of damage.");
    }
}
