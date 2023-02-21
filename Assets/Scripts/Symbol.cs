using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symbol : MonoBehaviour
{
    public Sprite sprite;
    public string itemName;
    public string description;
    public int baseValue;
    public int valueDestroy;
    public bool markedDestruction = false;
    public int caculatedValue;

    //用于检测的数据
    public List<string> ADOBuffObject;
    public List<string> ADODestroyObject;
    public int ADOBuffValue;
    public int spinToDestroy;
    public int turnsToDestroy;
    public string objectAddWhenDestroyed;
    public string objectAddEveryXTurnsORSpins;
    public int turnsToAddSTH;
    public int spinsToAddSTH;
    public string objectTurnInto;
    public int turnsToTurnInto;
    public int possibility;
    public int ID;

    public int[] points = new int[2] { -1, -1 };

    public Symbol()
    {
        ADOBuffObject = new List<string>();
        ADODestroyObject = new();
    }

    public Symbol(Symbol symbol)
    {
        sprite = symbol.sprite;
        itemName = symbol.itemName;
        description = symbol.description;
        baseValue = symbol.baseValue;
        valueDestroy = symbol.valueDestroy;
        markedDestruction = symbol.markedDestruction;
        caculatedValue = symbol.caculatedValue;
        spinToDestroy = symbol.spinToDestroy;
        turnsToDestroy = symbol.turnsToDestroy;
        ADOBuffValue = symbol.ADOBuffValue;
        objectAddWhenDestroyed = symbol.objectAddWhenDestroyed;
        objectAddEveryXTurnsORSpins = symbol.objectAddEveryXTurnsORSpins;
        turnsToAddSTH = symbol.turnsToAddSTH;
        spinsToAddSTH = symbol.spinsToAddSTH;
        objectTurnInto = symbol.objectTurnInto;
        turnsToTurnInto = symbol.turnsToTurnInto;
        possibility = symbol.possibility;
        ID = symbol.ID;
        ADOBuffObject = new List<string>();
        ADODestroyObject = new();
        foreach (var ADObject in symbol.ADOBuffObject)
        {
            ADOBuffObject.Add(ADObject);
        }
        foreach(var ADObject in symbol.ADODestroyObject)
        {
            ADODestroyObject.Add(ADObject);
        }
    }
}
