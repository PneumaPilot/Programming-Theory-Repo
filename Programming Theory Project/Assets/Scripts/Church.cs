using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Church
{
    protected int m_members;
    protected float m_treasury;

    public Church()
    {
        m_members = 0;
        m_treasury = 0;
    }

    public Church(int members)
    {
        if (members > 0)
        {
            m_members = members;
        }
        else
        {
            m_members = 0;
        }
        m_treasury = 0;
    }

    // ENCAPSULATION
    public int Members
    {
        get
        {
            return m_members;
        }
        set
        {
            if (value > 0)
            {
                m_members = value;
            }
            else
            {
                m_members = 0;
            }
        }
    }

    public float Treasury
    {
        get
        {
            return m_treasury;
        }
    }

    // ABSTRACTION
    public abstract void Pray(); // Print example prayer on screen

    public virtual void TakeOffering(float offering) // Adds money to the treasury
    {
        if (offering > 0)
        {
            m_treasury += offering;
        }
    }

    public abstract void Preach(); // Describe sermon on screen

    public abstract void Baptize(int numberOfConverts); // Describe baptism on screen

    public abstract void Sing(); // Describe sample song on screen

    public abstract void Communion(); // Describe communion celebration on screen
}
