// Abstrakte Klasse für Geschenke
public abstract class Geschenk : IMatchable
{
    protected string name;
    public string Name { get { return name; } }
    protected double gewicht;
    protected string groesse;
    protected int altersgruppe;
    public int Anzahl { get; set; }

    public Geschenk(string name, double gewicht, string groesse, int altersgruppe, int anzahl)
    {
        this.name = name;
        this.gewicht = gewicht;
        this.groesse = groesse;
        this.altersgruppe = altersgruppe;
        this.Anzahl = anzahl;
    }

    // Prüft, ob das Geschenk für das Kind geeignet ist
    public abstract bool IstGeeignet(Kind kind);
}
