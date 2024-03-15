using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Charismatic : Church
{
    public Charismatic()
    {
        this.m_name = "Charismatic";
    }

    public Charismatic(int members)
    {
        this.m_members = members;
        this.m_treasury = 0;
        this.m_name = "Charismatic";
    }

    //POLYMORPHISM
    public override string Pray()
    {
        return "Babala shobabba majobba shoe tie floribbabba hobba shoba toe. " +
            "Tie my bow tie moemah shoefah rubella jobbamamma shobabba shoe. Flobabba " +
            "megido florabbabba simajoobabba tinbabba foobar.";
    }

    public override string Preach()
    {
        return "The pastor reads the text he is going to preach, and then pauses" +
            " to pray for the Holy Spirit to speak through the text to our hearts." +
            "  He then exposits the text, using it as the foundational authority to " +
            "demand that the hearers live according to the way God has commanded.";
    }

    public override string Baptize(int numberOfConverts)
    {
        return "The pastor begins the serice in the baptistry, accompanied by " +
            "the " + numberOfConverts + " person(s) to be baptized.  He asks them" +
            " if they know Jesus as their Savior, and then baptized them in the name " +
            "of the Father, and the Son, and the Holy Spirit by immersing them in water.";
    }

    public override string Communion()
    {
        return "The deacons come forward and prepare the table while the pastor tells" +
            " the congregation to examine themselves.  He warns unbelievers not to partake," +
            " and encourages everyone to hold the elements so we can partake together.  The" +
            " observance is a symbol and a memorial.";
    }

    public override string Sing()
    {
        return "A song leader or praise team leads the congregation to sing hymns from " +
            "the revivalistic era, psalms, praise choruses, or modern hymns or Christian " +
            "songs.  The mix is heavily weighted toward repetitive mantra-like songs.";
    }
}
