
// Beispielprogramm für Santas Werkstatt
using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
			// Erstelle einige Kinder
			var kind1 = new Kind("Gian", 7, "Spielzeug", "Wunderstrasse 69");
			var kind2 = new Kind("Zoe", 5, "Essen", "Platzspitz 420");
			var kind3 = new Kind("Luca", 6, "Spielzeug", "Winterweg 1");
			var kind4 = new Kind("Mia", 8, "Essen", "Sommerallee 2");

			// Erstelle Geschenke (mit Stückzahl)
			var spielzeug = new SpielzeugGeschenk("Teddy", 0.5, "klein", 3, "Plüschtier", 1);
			var essen = new EssensGeschenk("Schokolade", 0.2, "klein", 4, true, 1);

			// Erstelle Werkstatt
			var werkstatt = new SantasWorkshop();
			werkstatt.KindHinzufuegen(kind1);
			werkstatt.KindHinzufuegen(kind2);
			werkstatt.KindHinzufuegen(kind3);
			werkstatt.KindHinzufuegen(kind4);
			werkstatt.GeschenkHinzufuegen(spielzeug);
			werkstatt.GeschenkHinzufuegen(essen);

			// Verteile Geschenke
			List<Kind> ohneGeschenk;
			Dictionary<Kind, Geschenk> zuordnung = werkstatt.VerteileGeschenke(out ohneGeschenk);

			// Ausgabe
			foreach (var eintrag in zuordnung)
			{
				// Gibt den Namen des Kindes und des Geschenks aus
				Console.WriteLine($"{eintrag.Key.Name} bekommt {eintrag.Value.GetType().Name}: {eintrag.Value.Name}");
			}
			// Kinder ohne Geschenk ausgeben
			if (ohneGeschenk.Count > 0)
			{
				Console.WriteLine("\nKinder ohne Geschenk:");
				foreach (var kind in ohneGeschenk)
				{
					Console.WriteLine(kind.Name);
				}
			}
	}
}
