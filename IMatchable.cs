// Schnittstelle für passende Geschenke
public interface IMatchable
{
    // Prüft, ob das Geschenk für das Kind geeignet ist
    bool IstGeeignet(Kind kind);
}
