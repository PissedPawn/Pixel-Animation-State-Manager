using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputManager 
{
   float x {get; set;}
   float y {get; set;}

   bool basicAttack{get; set;}
   bool jump {get; set;}

}
