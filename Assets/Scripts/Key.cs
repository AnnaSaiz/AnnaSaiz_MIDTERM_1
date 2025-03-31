using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor
{
    Green,
    Blue,
    Red
}

public class Key : MonoBehaviour
{
    public KeyColor keyColor;

    private void Start()
    {
        if(keyColor == KeyColor.Green)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else if (keyColor == KeyColor.Blue)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (keyColor == KeyColor.Red)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>(); //get reference to the Player component of object

            if (keyColor == KeyColor.Green) // if enum keycolor is green
            {
                if (player.hasGreenKey == false) // does the player have green key?
                {
                    player.hasGreenKey = true; // player has green key = yes
                    Destroy(gameObject); //destroy green key, not the player
                }
            }
            else if (keyColor == KeyColor.Blue) //if enum keycolor is blue
            {
                if (player.hasBlueKey == false) // does player have blue key
                {
                    player.hasBlueKey = true; //player has blue key = yes
                    Destroy(gameObject); // destroy blue key
                }
            }
            else if (keyColor == KeyColor.Red) //red not blueee
            {
                if (player.hasRedKey == false) //does player have red key
                {
                    player.hasRedKey = true; //player has red key = yes
                    Destroy(gameObject); //Destroy red
                }
            }
            
        }
    }
}
