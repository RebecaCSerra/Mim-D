using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aviaoinimigo : MonoBehaviour
{
    public SliderJoint2D slider;
    public JointMotor2D temp;
    // Start is called before the first frame update
    void Start()
    {
        temp = slider.motor;
    }

    void Update()
    {
        if (slider.limitState == JointLimitState2D.LowerLimit)
        {
            temp.motorSpeed = 5;
            slider.motor = temp;
        }

        if (slider.limitState == JointLimitState2D.UpperLimit)
        {
            temp.motorSpeed = -5;
            slider.motor = temp;

        }
    }
}

