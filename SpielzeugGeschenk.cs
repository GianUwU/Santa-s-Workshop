// Geschenkart: Spielzeug
public class SpielzeugGeschenk : Geschenk
{
    private string spielArt;

    public SpielzeugGeschenk(string name, double gewicht, string groesse, int altersgruppe, string spielArt, int anzahl)
        : base(name, gewicht, groesse, altersgruppe, anzahl)
    {
        this.spielArt = spielArt;
    }

    // Prüft, ob das Geschenk für das Kind geeignet ist
    public override bool IstGeeignet(Kind kind)
    {
        // Einfaches Beispiel: Wunschart muss "Spielzeug" sein und Alter passen
        return kind.WunschArt == "Spielzeug" && kind.Alter >= altersgruppe;
    }
}
