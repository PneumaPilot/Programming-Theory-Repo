using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Church : MonoBehaviour
{
    private int m_members;
    private float m_treasury;

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
}
