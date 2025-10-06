using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name = "ball"; //defines public string variable 'Name' and sets it to value "ball"

    public override string ToString() //overrides the default ToString() method
    {
        return Name; //returns string directly
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.CollectItem(this); // Add item to inventory
                Destroy(gameObject);      // Remove the item from the scene
            }
        }
    }
}