using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Church
{
    protected int m_members;
    protected float m_treasury;
    protected string m_name;

    public Church()
    {
        m_members = 0;
        m_treasury = 0;
        m_name = "Unassigned";
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
        m_name = "Unassigned";
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

    public string DenominationName
    {
        get
        {
            return m_name;
        }
    }

    // ABSTRACTION
    public abstract string Pray(); // Print example prayer on screen

    public virtual void TakeOffering(float offering) // Adds money to the treasury
    {
        if (offering > 0)
        {
            m_treasury += offering;
        }
    }

    public abstract string Preach(); // Describe sermon on screen

    public abstract string Baptize(int numberOfConverts); // Describe baptism on screen

    public abstract string Sing(); // Describe sample song on screen

    public abstract string Communion(); // Describe communion celebration on screen
}
