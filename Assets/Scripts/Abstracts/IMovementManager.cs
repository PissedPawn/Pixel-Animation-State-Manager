using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementManager 
{
     Rigidbody2D rb {get; set;}
    IInputManager inputManager{get; set;}
    bool isFacingRight{get; set;}
     float speed {get; set;}

     float jumpForce{get; set;}
}
