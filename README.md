# Santa-s-Workshop



@startuml

' ===== Interface =====
interface IMatchable {
  + istGeeignet(kind : Kind) : boolean
}

' ===== Abstrakte Klasse =====
abstract class Geschenk {
  - name : String
  - gewicht : double
  - groesse : String
  - altersgruppe : int
  - anzahl : int
  + istGeeignet(kind : Kind) : boolean
}

Geschenk ..|> IMatchable

' ===== Vererbung =====
class SpielzeugGeschenk {
  - spielArt : String
  - anzahl : int
  + istGeeignet(kind : Kind) : boolean
}

class EssensGeschenk {
  - allergenfrei : boolean
  - anzahl : int
  + istGeeignet(kind : Kind) : boolean
}

Geschenk <|-- SpielzeugGeschenk
Geschenk <|-- EssensGeschenk

' ===== Kind =====
class Kind {
  - name : String
  - alter : int
  - wunschArt : String
  - adresse : String
}

' ===== Workshop =====
class SantasWorkshop {
  - geschenke : List<Geschenk>
  - kinder : List<Kind>
  + geschenkHinzufuegen(g : Geschenk)
  + kindHinzufuegen(k : Kind)
  + verteileGeschenke() : (Map<Kind, Geschenk>, List<Kind>)
}

' ===== Beziehungen =====
SantasWorkshop "1" o-- "*" Geschenk
SantasWorkshop "1" o-- "*" Kind

@enduml
