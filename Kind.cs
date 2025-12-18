// Klasse für Kinder
public class Kind
{
    public string Name { get; set; }
    public int Alter { get; set; }
    // Wunschart (z.B. "Spielzeug" oder "Essen")
    public string WunschArt { get; set; }
    // Adresse des Kindes
    public string Adresse { get; set; }

    public Kind(string name, int alter, string wunschArt, string adresse)
    {
        Name = name;
        Alter = alter;
        WunschArt = wunschArt;
        Adresse = adresse;
    }
}
