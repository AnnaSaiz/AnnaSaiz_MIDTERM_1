using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false;
    public bool hasBlueKey = false;
    public bool hasRedKey = false;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //if player presses E
        {
            RaycastHit hit; //declare raycast variable as hit

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit)) 
            {
               
                if (hit.collider.tag == "Door") //if ray cast hits object with tag door
                {
                    LockedDoor door = hit.collider.GetComponent<LockedDoor>(); //get collider component from locked door
                    
                    if (door.isDoorLocked == false) //if is door locked is false
                    {
                        door.OpenDoor(); //run OpenDoor
                    }
                    else 
                    {
                        if (door.keyColorRequired == KeyColor.Green && hasGreenKey) //if player has green key
                        {
                            door.OpenDoor();
                        }
                          else if (door.keyColorRequired == KeyColor.Blue && hasBlueKey)
                        {
                            door.OpenDoor();
                        }
                        else if (door.keyColorRequired == KeyColor.Red && hasRedKey)
                        {
                            door.OpenDoor();
                        }

                           
                        
                    }
                    
                }
            }
        }
    }
}
