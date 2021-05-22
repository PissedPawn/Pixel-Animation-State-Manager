using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerAnimatorManager : MonoBehaviour, IAnimatorManager
{
    public Animator animator { get; set; }
    private string currentState;
    public IInputManager inputManager { get; set; }


    const string Idle= "IdleAnimation";
    const string Walk= "WalkAnimation";
    const string Jump= "JumpAnimation";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        inputManager = GetComponent<PlatformerInputManager>();
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);
        currentState = newState;
    }


    void Update()
    {
        if(inputManager.x!=0)
        {
            ChangeAnimationState(Walk);
        }

        else 
        {
            ChangeAnimationState(Idle);
        }

        if(inputManager.jump)
        {
            ChangeAnimationState(Jump);
        }
    }


}
