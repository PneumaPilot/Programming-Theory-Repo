using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Baptist : Church
{
    public Baptist() { }

    public Baptist(int members)
    {
        this.m_members = members;
        this.m_treasury = 0;
    }

    //POLYMORPHISM
    public override void Pray()
    {
        // Print Baptist prayer
    }

    public override void Preach()
    {
        // Describe Baptist sermon
    }

    public override void Baptize(int numberOfConverts)
    {
        // Describe baptism and add members
    }

    public override void Communion()
    {
        // Describe Baptist communion
    }

    public override void Sing()
    {
        // Describe example song
    }
}
