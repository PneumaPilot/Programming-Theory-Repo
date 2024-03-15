using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Presbyterian : Church
{
    public Presbyterian()
    {
        this.m_name = "Presbyterian";
    }

    public Presbyterian(int members)
    {
        this.m_members = members;
        this.m_treasury = 0;
        this.m_name = "Presbyterian";
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
        return "The preaching elder reads the text he is going to preach, and then pauses" +
            " to pray for the Holy Spirit to speak through the text to our hearts." +
            "  He then exposits the text, using it as the foundational authority to " +
            "demand that the hearers live according to the way God has commanded.";
    }

    public override string Baptize(int numberOfConverts)
    {
        return "The lead elder has the parents of the " + numberOfConverts + " infants " +
            "line up in front of a small font of water.  He then sprinkles a little " +
            "on each of the babies - in total denial of even the plain meaning of the word " +
            "'baptize'.";
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
            "the revivalistic era, or modern hymns or Christian " +
            "songs.  The mix is weighted heavily toward Psalms from the Psalter.";
    }
}
