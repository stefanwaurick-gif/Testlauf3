# Feature List: Racing Manager 2026

Dieses Dokument beschreibt die geplanten Features für das Spiel "Racing Manager 2026".

---

## 1. Kern-Gameplay
**Status:** Nicht begonnen

### 1.1. Team-Management
**Status:** In Bearbeitung
- **Schlüsselpersonal:** Einstellen und Verwalten von kritischen Rollen. Jede Person hat Attribute (Skills 1-20, Gehaltsvorstellung, etc.).
  - *Technischer Direktor:* Beeinflusst die gesamte F&E-Richtung.
  - *Chef-Aerodynamiker:* Verantwortlich für Aerodynamik-Projekte.
  - *Renningenieure (x2):* Arbeiten direkt mit den Fahrern am Rennwochenende.
  - *Scouts:* Finden neue Talente (Fahrer und Personal).
- **Fahrerverträge:** Detaillierte Vertragsverhandlungen.
  - *Klauseln:* Grundgehalt, Laufzeit, Ausstiegsklauseln, Leistungsboni (Siege, Podien, WM-Titel), Loyalitätsboni.
- **Personalentwicklung:** Gezielte Verbesserung der Personal-Skills.
  - *Methoden:* Investition in Mentoring-Programme, Simulatortraining oder externe Kurse zur Steigerung spezifischer Skill-Werte.

### 1.2. Fahrzeugentwicklung (R&D)
**Status:** In Bearbeitung
- **F&E-Projekte:** Spieler initiieren Projekte zur Entwicklung spezifischer Fahrzeugteile.
  - *Parameter:* Jedes Projekt hat definierte Kosten, eine Dauer (in Tagen) und benötigt Ingenieursstunden.
  - *Erfolg & Durchbrüche:* Der Erfolg wird durch die Fähigkeiten des Personals (z.B. Chef-Aerodynamiker) und die Stufe der Infrastruktur (z.B. Windkanal) beeinflusst. Es besteht die Chance auf einen "Durchbruch", der zu einem unerwartet großen Leistungsgewinn führt.
- **Fahrzeugkomponenten:** Das Auto besteht aus mehreren Schlüsselkomponenten, die entwickelt und gefertigt werden.
  - *Komponenten-Liste:* Chassis, Motor, Getriebe, Frontflügel, Heckflügel, Unterboden, Seitenkästen.
  - *Attribute:* Jedes Teil hat Werte für Leistung (z.B. Abtrieb, PS), Haltbarkeit und Gewicht, die die Gesamtperformance des Autos beeinflussen.
- **Fertigung:** Neu entwickelte Teile müssen produziert werden, bevor sie am Auto montiert werden können.
  - *Kapazität & Kosten:* Die Fertigungskapazität ist durch die Fabrikgröße begrenzt. Jedes Teil hat individuelle Produktionskosten.
- **Reglementänderungen:** Jährliche Änderungen der technischen Regeln zwingen zur Anpassung.
  - *Anpassungsdruck:* Bestimmte Teile könnten für die nächste Saison illegal werden, was eine Neuentwicklung erzwingt.
- **Regel-Grauzonen & Risiko:** Der Spieler kann riskante, potenziell nicht regelkonforme Teile entwickeln.
  - *Mechanik:* Diese Teile bieten einen hohen Leistungsschub, bergen aber das Risiko, bei einer technischen Inspektion nach dem Rennen entdeckt zu werden.
  - *Konsequenzen:* Strafen können von einer Geldstrafe über eine Disqualifikation vom Rennen bis hin zu einem Forschungsverbot für die Komponente reichen.

### 1.3. Finanzmanagement
**Status:** In Bearbeitung
- **Sponsorenverträge:** Aushandeln von Verträgen mit verschiedenen Sponsoren.
  - *Sponsoren-Typen:* Hauptsponsor (1 pro Saison, hoher Wert, hohe Anforderungen) und Nebensponsoren (mehrere möglich, geringerer Wert).
  - *Vertrags-Struktur:* Fixe Zahlung pro Rennen, Leistungsboni (für Punkte, Podien, Siege) und Saisonziele (z.B. Konstrukteurs-WM Platz 5).
- **Budget-Allokation:** Zuweisung des Gesamtbudgets zu verschiedenen Kostenstellen.
  - *Kostenstellen:* F&E, Fertigung, Personalgehälter, Infrastruktur-Instandhaltung.
  - *Flexibilität:* Mittel können zwischen den Kostenstellen verschoben werden, evtl. mit einer kleinen Verwaltungsgebühr.
- **Einnahmen & Ausgaben:** Detaillierte Übersicht über alle Geldflüsse.
  - *Weitere Einnahmen:* Preisgelder (basierend auf WM-Endstand) und Merchandising (passives Einkommen basierend auf Team-Prestige).
  - *Laufende Kosten:* Wöchentliche oder monatliche Abrechnung von Gehältern und Instandhaltung.

### 1.4. Infrastruktur
**Status:** In Bearbeitung
- **Ausbaubare Einrichtungen:** Jede Einrichtung kann in mehreren Stufen ausgebaut werden. Jede Stufe kostet Zeit und Geld, schaltet aber Boni frei.
  - **Fabrik:** Beeinflusst Fertigungsgeschwindigkeit, -kapazität und Haltbarkeit der Teile.
    - *Stufe 1:* Standard. *Stufe 2:* +1 Fertigungs-Slot, +5% Haltbarkeit. *Stufe 3:* +2 Fertigungs-Slots, +10% Haltbarkeit.
  - **Windkanal:** Verbessert die Effektivität der Aerodynamik-Forschung.
    - *Stufe 1:* Standard. *Stufe 2:* +10% Forschungs-Effizienz für Aero. *Stufe 3:* +25% Forschungs-Effizienz, schaltet "intensive Simulation" frei.
  - **Fahrsimulator:** Verbessert die Fähigkeiten der Fahrer und liefert Setup-Daten.
    - *Stufe 1:* Standard. *Stufe 2:* +5% Fahrer-XP pro Woche. *Stufe 3:* +10% Fahrer-XP, schaltet vor dem Rennwochenende eine Setup-Empfehlung frei.
  - **Scouting-Abteilung:** Verbessert die Genauigkeit der Berichte über junge Talente.
    - *Stufe 1:* Standard. *Stufe 2:* Deckt "Potenzial"-Rating auf. *Stufe 3:* Deckt verborgene Fahrer-Eigenschaften auf.

### 1.5. Personal-Moral und Beziehungen
**Status:** Nicht begonnen
- **Moral-System:** Jeder Mitarbeiter hat einen Moral-Wert (1-100), der seine Leistung beeinflusst.
  - *Einflussfaktoren:* Teamerfolg, persönliche Gespräche, Gehalt, Gefühl der Wertschätzung. Niedrige Moral kann zu Leistungsabfall oder Kündigungswünschen führen.
- **Interne Beziehungen:** Bestimmte Personal-Paarungen können positive oder negative Synergien entwickeln.
  - *Beispiel:* Ein Renningenieur und ein Fahrer, die sich gut verstehen, schalten einen kleinen Setup-Bonus frei. Ein Konflikt zwischen Technischem Direktor und Chef-Aerodynamiker verlangsamt die F&E.

## 2. Das Rennwochenende
**Status:** In Bearbeitung

### 2.1. Simulation
**Status:** Nicht begonnen
- **Ansichts-Modi:** Verschiedene Perspektiven zur Beobachtung des Rennens.
  - *TV-Kamera:* Dynamische Kameras entlang der Strecke wie bei einer Fernsehübertragung.
  - *Onboard-Kamera:* Mitfahren aus der Perspektive eines beliebigen Fahrers.
  - *2D-Kartenansicht:* Taktische Übersicht aller Fahrzeuge auf der Strecke in Echtzeit.
- **Daten-Dashboard (HUD):** Anpassbare Widgets mit allen wichtigen Informationen.
  - *Live-Zeitnahme:* Klassischer Zeitenturm mit Positionen, Fahrernamen, Abständen und Rundenzeiten.
  - *Zustandsanzeigen (Spieler):* Detaillierte Anzeige für die eigenen Fahrer: Reifenzustand (%), Benzinmenge (in Runden), ERS-Ladung (%), aktuelle Pace/ERS-Modi.
  - *Wetter-Radar:* Eine Mini-Karte, die herannahenden Regen und dessen Intensität anzeigt.

### 2.2. Strategie
**Status:** In Bearbeitung
- **Setup-Abstimmung:** Anpassen des Fahrzeug-Setups während der Trainings.
  - *Parameter:* Flügel-Einstellung (Aero-Balance), Reifendruck (Grip vs. Verschleiß), Bremsbalance.
  - *Fahrer-Feedback:* Der Fahrer gibt qualitatives Feedback (z.B. "Übersteuern am Kurveneingang"), das dem Spieler hilft, das Setup zu optimieren.
- **Boxenstopp-Planung:** Erstellen von Rennstrategien vor dem Rennen.
  - *Stints:* Festlegen der Runden für Boxenstopps und der zu verwendenden Reifenmischung (Soft, Medium, Hard, Inter, Wet) für jeden Stint.
  - *Live-Anpassung:* Die Strategie kann während des Rennens als Reaktion auf Ereignisse (z.B. Safety Car) geändert werden.
- **Anweisungen während des Rennens:** Direkte Befehle an die Fahrer.
  - *Pace-Management:* `Reifen/Sprit schonen`, `Neutral fahren`, `Attackieren`. Beeinflusst Rundenzeit, Reifen- und Benzinverbrauch.
  - *ERS-Management:* `Aufladen`, `Neutral`, `Überholen`. Steuert den Einsatz der elektrischen Energie.
- **Dynamisches Wetter:** Das Wetter spielt eine entscheidende Rolle.
  - *Vorhersage-Genauigkeit:* Die Wettervorhersage hat eine prozentuale Sicherheit, was strategische Risiken schafft.

## 3. Spielmodi
**Status:** Nicht begonnen

### 3.1. Karriere-Modus
**Status:** Nicht begonnen
- **Team erstellen:** Starte mit einem komplett neuen Team von Grund auf.
- **Bestehendes Team übernehmen:** Übernimm die Leitung eines etablierten Teams und führe es zum Erfolg.
- **Langzeit-Motivation:** Aufstieg durch verschiedene Rennserien.

### 3.2. Multiplayer
**Status:** Nicht begonnen
- **Online-Ligen:** Erstelle oder trete Ligen mit Freunden bei und fahre eine komplette Saison.
- **Head-to-Head:** Fordere andere Spieler zu einzelnen Rennen heraus.
- **Koop-Karriere:** Zwei Spieler leiten gemeinsam ein Team und teilen sich die Verantwortlichkeiten (z.B. einer für F&E/Finanzen, der andere für das Rennwochenende).

## 4. Sonstiges
**Status:** In Überarbeitung

### 4.1. Fahrerakademie
**Status:** Detailliert
- **Scouting & Rekrutierung:** Junge Talente (15-18 Jahre) weltweit über das Scouting-Netzwerk finden. Jeder Fahrer hat sichtbare Basis-Skills und verborgenes Potenzial.
- **Entwicklungsprogramm:** Investition in verschiedene Trainingsprogramme (z.B. Kartsport, Formel 4, Formel 3), um die Skills der Nachwuchsfahrer gezielt zu verbessern.
- **Vertragsbindung:** Nachwuchsfahrer unterzeichnen Optionsverträge. Der Spieler kann sie zum Testfahrer befördern oder ihnen ein Stammcockpit anbieten, wenn sie bereit sind.

### 4.2. Team-Rivalitäten
**Status:** Nicht begonnen
- **Dynamisches System:** Basierend auf der Performance und direkten Duellen auf der Strecke entstehen Rivalitäten mit anderen Teams.
- **Auswirkungen:** Erhöht die Medienaufmerksamkeit, schafft spezielle Sponsoren-Boni (z.B. "Schlage Team X in den nächsten 3 Rennen") und beeinflusst die Moral.

### 4.3. Dynamische Story-Events
**Status:** Nicht begonnen
- **Szenario-basiert:** Zufällige oder getriggerte Ereignisse, die den Spieler vor Entscheidungen stellen.
  - *Beispiele:* Ein reicher Investor bietet an, das Team zu kaufen; der Hauptsponsor droht mit Rückzug nach einer Pechsträhne; ein wichtiger Ingenieur erhält ein Angebot von einem Konkurrenzteam.
- **Entscheidungsfreiheit:** Die Wahl des Spielers hat kurz- und langfristige Konsequenzen für Finanzen, Moral und Teamleistung.

### 4.4. Medien & Presse
**Status:** Detailliert
- **Interaktive Interviews:** Nach dem Rennen wird der Spieler mit Fragen von Journalisten konfrontiert.
  - *Antwort-Optionen:* Die Antworten können die Moral der Fahrer (loben/kritisieren), des Personals oder die Beziehung zu Sponsoren und Rivalen beeinflussen.
- **Presse-Stimmung:** Die Medien entwickeln eine allgemeine Haltung gegenüber dem Team (z.B. "Aufsteiger", "Kriselnd"), die sich auf das Team-Prestige auswirkt.

### 4.5. Customization
**Status:** Nicht begonnen
- **Team-Editor:** Werkzeuge zur Gestaltung der Fahrzeuglackierung, des Team-Logos und der Team-Kleidung.
- **Fahrer-Editor:** Anpassung von Helm-Design und Rennanzug für die eigenen Fahrer.
