using System.Collections.Generic;

using UnityEngine;

public class BringThemBack : MonoBehaviour
{
    public List<Target> inactiveTargets = new List<Target>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) //if player presses R
        {
            for (int i = 0; i < inactiveTargets.Count; i++) 
            {
                inactiveTargets[i].gameObject.SetActive(true);

                //checks all items on the list and sets them to active when R is pressed
            }


        }
    }
}
