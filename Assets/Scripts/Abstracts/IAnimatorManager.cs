using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAnimatorManager 
{
    Animator animator{get; set;}
    IInputManager inputManager{get; set;}
   
}
