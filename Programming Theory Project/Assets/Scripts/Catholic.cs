using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Catholic : Church
{
    public Catholic() { }

    public Catholic(int members)
    {
        this.m_members = members;
        this.m_treasury = 0;
    }

    // POLYMORPHISM
    public override void Pray()
    {
        // Print Catholic prayer
    }

    public override void Preach()
    {
        // Describe Catholic sermon
    }

    public override void Baptize(int numberOfConverts)
    {
        // Describe baptism and add members
    }

    public override void Communion()
    {
        // Describe Catholic communion
    }

    public override void Sing()
    {
        // Describe example song
    }
}
