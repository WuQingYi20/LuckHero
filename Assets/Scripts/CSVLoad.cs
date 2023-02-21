using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CSVLoad : MonoBehaviour
{
    public static List<Symbol> symbols = new();
    public static Dictionary<string, Symbol> symbolsDict = new();

    private void Start()
    {
        //ReadCSV("Test");
        ReadCSV("ItemValue");
    }

    public static void ReadCSV(string CSVPath)
    {
        TextAsset temp = Resources.Load<TextAsset>(CSVPath);
        String[] splitText = temp.text.Split(new char[] { '\n' });

        for (int i = 1; i < splitText.Length - 1 ; i++)
        {
            string[] row = splitText[i].Split(new char[] { ',' });
            Symbol symbolTemp = new Symbol();
            symbolTemp.itemName = row[0];
            symbolTemp.description = row[1];
            //Debug.Log("row[2]: " + row[2]);
            symbolTemp.baseValue = Int32.Parse(row[2]);
            symbolTemp.caculatedValue = Int32.Parse(row[2]);
            symbolTemp.valueDestroy = Int32.Parse(row[3]);
            //下面的变量用于检测
            symbolTemp.ADOBuffObject = new List<string>(row[4].Split(new char[] { ';' }));
            symbolTemp.ADODestroyObject = new List<string>(row[5].Split(new char[] { ';' }));
            symbolTemp.ADOBuffValue = Int32.Parse(row[6]);
            symbolTemp.spinToDestroy = Int32.Parse(row[7]);
            symbolTemp.turnsToDestroy = Int32.Parse(row[8]);
            symbolTemp.objectAddWhenDestroyed = row[9];
            symbolTemp.objectAddEveryXTurnsORSpins = row[10];
            symbolTemp.turnsToAddSTH = Int32.Parse(row[11]);
            symbolTemp.spinsToAddSTH = Int32.Parse(row[12]);
            symbolTemp.objectTurnInto = row[13];
            symbolTemp.turnsToAddSTH = Int32.Parse(row[14]);
            symbolTemp.possibility = Int32.Parse(row[15]);

            symbolTemp.points = new int[2] { -1, -1 };
            //symbolTemp.name = i.ToString();
            symbolTemp.ID = i;
            symbols.Add(symbolTemp);
            //Debug.Log("itemName: " + );
            symbolsDict.Add(row[0], symbolTemp);
        }
    }
}
