// Geschenkart: Essen
public class EssensGeschenk : Geschenk
{
    private bool allergenfrei;

    public EssensGeschenk(string name, double gewicht, string groesse, int altersgruppe, bool allergenfrei, int anzahl)
        : base(name, gewicht, groesse, altersgruppe, anzahl)
    {
        this.allergenfrei = allergenfrei;
    }

    // Prüft, ob das Geschenk für das Kind geeignet ist
    public override bool IstGeeignet(Kind kind)
    {
        // Einfaches Beispiel: Wunschart muss "Essen" sein und Alter passen
        return kind.WunschArt == "Essen" && kind.Alter >= altersgruppe && allergenfrei;
    }
}
