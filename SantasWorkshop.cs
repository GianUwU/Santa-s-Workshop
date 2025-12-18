using System.Collections.Generic;
public class SantasWorkshop
{
    private List<Geschenk> geschenke = new List<Geschenk>();
    private List<Kind> kinder = new List<Kind>();

    public void GeschenkHinzufuegen(Geschenk g)
    {
        geschenke.Add(g);
    }
    public void KindHinzufuegen(Kind k)
    {
        kinder.Add(k);
    }

    // Geschenke verteilen
    public Dictionary<Kind, Geschenk> VerteileGeschenke(out List<Kind> ohneGeschenk)
    {
        var result = new Dictionary<Kind, Geschenk>();
        var geschenkZaehler = new Dictionary<Geschenk, int>();
        foreach (var g in geschenke)
        {
            geschenkZaehler[g] = g.Anzahl;
        }

        foreach (var kind in kinder)
        {
            bool bekommen = false;
            foreach (var geschenk in geschenke)
            {
                if (geschenk.IstGeeignet(kind) && geschenkZaehler[geschenk] > 0)
                {
                    result[kind] = geschenk;
                    geschenkZaehler[geschenk]--;
                    bekommen = true;
                    break;
                }
            }
        }
        // Kinder ohne Geschenk sammeln
        ohneGeschenk = new List<Kind>();
        foreach (var kind in kinder)
        {
            if (!result.ContainsKey(kind))
                ohneGeschenk.Add(kind);
        }
        return result;
    }
}
