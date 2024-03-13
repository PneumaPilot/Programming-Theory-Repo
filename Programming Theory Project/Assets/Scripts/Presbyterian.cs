using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Presbyterian : Church
{
    public Presbyterian() { }

    public Presbyterian(int members)
    {
        this.m_members = members;
        this.m_treasury = 0;
    }

    //POLYMORPHISM
    public override void Pray()
    {
        // Print Presbyterian prayer
    }

    public override void Preach()
    {
        // Describe Presbyterian sermon
    }

    public override void Baptize(int numberOfConverts)
    {
        // Describe baptism and add members
    }

    public override void Communion()
    {
        // Describe Presbyterian communion
    }

    public override void Sing()
    {
        // Describe example song
    }
}
