using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //Attributes

    //Public
    public string characterName;
    public List<Spell> spellsBook;
    public bool summonSpell;
    //Private
    private int _life;
    private int _mana;

    

    //Methods 
    
    //Public
    public void CastSpell() //Verifies if a Spell was trigger 
    {
       int count = 0;
       foreach (Spell spell in spellsBook)
        {
            if (spell.trigger)
            {
                CheckSpell(spell);
                
            }
            else
            {
                count++;
            }
            
        }
       if (count == spellsBook.Count)
        {
            print("You don't have any spell activated");
        }
        ShowStatus();
    }
   
    //Private
    
    private void CheckSpell (Spell spell) //verifies what kind of Spell is and activate its effect
    {
        if (_mana >= spell.GetManaCost())
        { 
            _mana -= spell.GetManaCost();
            spell.trigger = false;
            spell.SpellEfect();
            if (spell is FireSpell)
            {
                _life -= 100; //Life decrease by burn of fire spell
            }
        }
        else
        {
            print($"You don't have enought mana to use {spell.GetSpellname()}");
            spell.trigger = false;
        }
    }
    private void ShowStatus () //Show charater stats (Life and mana)
    {
        print($"Life points: {_life}           Mana points: {_mana} ");
    }
    private void Start()
    {
        _life = 1500;
        _mana = 900;
        spellsBook.Add(gameObject.AddComponent<FireSpell>()); 
        spellsBook.Add(gameObject.AddComponent<WaterSpell>());

        ShowStatus();
  
    }
    private void Update()
    {
        if(summonSpell)
        {
            CastSpell();
            summonSpell = false;
        }
    }
}
