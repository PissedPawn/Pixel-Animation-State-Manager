using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerInputManager : MonoBehaviour, IInputManager
{
    public float x { get; set; }
    public float y { get; set; }
    public bool basicAttack { get; set; }
    public bool jump {get; set;}

    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
           
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            jump=false;
        }
    }
}
