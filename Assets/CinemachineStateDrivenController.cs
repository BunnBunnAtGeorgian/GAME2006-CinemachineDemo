using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemachineStateDrivenController : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void TransitionToGroupCamera()
    {
        anim.SetBool("isGroupState", true);
    }

    public void TransitionToPlayerCamera()
    {
        anim.SetBool("isGroupState", false);
    }
}
