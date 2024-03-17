using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Catholic : Church
{
    public Catholic()
    {
        this.m_name = "Catholic";
    }

    public Catholic(int members)
    {
        this.m_members = members;
        this.m_treasury = 0;
        this.m_name = "Catholic";
    }

    // POLYMORPHISM
    public override string Pray()
    {
        return "Hail Mary, full of grace, The Lord is with thee.  Blessed art " +
            "thou amongst women, And blessed is the fruit of thy womb, Jesus.  " +
            "  Holy Mary, Mother of God, Pray for us sinners, Now and at the " +
            " hour of our death.  Amen.";
    }

    public override string Preach()
    {
        return "The priest gets up and gives a short homily that isn't really " +
            "built on the foundation of a clear teaching of the Word.  It is " +
            "more of a cultural platitude than anything else.";
    }

    public override string Baptize(int numberOfConverts)
    {
        return "The priest has the parents of the " + numberOfConverts + " infants " +
            "line up in front of a small font of water.  He then sprinkles a little " +
            "on each of the babies - in total denial of even the plain meaning of the word " +
            "'baptize'.";
    }

    public override string Communion()
    {
        return "The priest takes some wafers and dunks them in a big wine glass and " +
            "then places that on the tongue of each person who comes forward to receive " +
            "it.  He tells the congregation that he has magically converted bread and wine " +
            "into the actual body and blood of Jesus.";
    }

    public override string Sing()
    {
        return "A choir - sometimes placed behind the congregation, and sometimes to " +
            "the side - sings some songs, possibly in Latin.  The congregation will sing " +
            "a couple of familiar hymns from some kind of song book.";
    }
}
