using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
  public string Name = "ball"; //defines public string variable 'Name' and sets it to value "ball"
  public Item (string name) //runs when new item is created and allows you to set its name
    {
        Name = name;
    }

  public override string ToString() //overrides the default ToString() method
    {
        return Name; //returns string directly
    }
}
