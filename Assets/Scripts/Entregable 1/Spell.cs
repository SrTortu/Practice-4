using UnityEngine;

public class Spell : MonoBehaviour
{
    //Attributes
    //Public
    public bool trigger;

    //Private
    private string _spellName;
    private string _spellEffect;
    private int _power;
    private int _manaCost ;
    
    //Methods
    //Public
   

    public void SetManaCost (int manaCost)
    {
        _manaCost = manaCost;
    }
    public int GetManaCost()
    {
        return _manaCost;
    }
    public void SetSpellName (string spellName)
    {
        _spellName = spellName;
    }

    public string GetSpellname ()
    {
        return _spellName;
    }

    public void SetPower  (int power)
    {
        _power = power;
    }

    public int GetPower ()
    {
        return _power;
    }
    
    public void SetEffect (string effect)
    {
        _spellEffect = effect;
    }


    public void SpellEfect() 
    {
        print($"You has cast the spell: {_spellName}. {_spellEffect}");
    }
    //Private
    private void Start()
    {
        trigger = false;    
    }

}
