using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Charismatic : Church
{
    public Charismatic() { }

    public Charismatic(int members)
    {
        this.m_members = members;
        this.m_treasury = 0;
    }

    //POLYMORPHISM
    public override void Pray()
    {
        // Print Charismatic prayer
    }

    public override void Preach()
    {
        // Describe Charismatic sermon
    }

    public override void Baptize(int numberOfConverts)
    {
        // Describe baptism and add members
    }

    public override void Communion()
    {
        // Describe Charismatic communion
    }

    public override void Sing()
    {
        // Describe example song
    }
}
