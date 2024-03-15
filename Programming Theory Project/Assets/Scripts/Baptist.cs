using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Baptist : Church
{
    public Baptist()
    {
        this.m_name = "Baptist";
    }

    public Baptist(int members)
    {
        this.m_members = members;
        this.m_treasury = 0;
        this.m_name = "Baptist";
    }

    //POLYMORPHISM
    public override string Pray()
    {
        return "Father in heaven, we praise you for your awesome glory," +
            " and it is our desire today to give you the praise that you deserve." +
            "  We ask for your blessing on our service today.  Speak to us through" +
            " your Word.";
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
            "songs.  The mix can vary dependent on congregation age.";
    }
}
