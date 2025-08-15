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
- **Fahrer-Eigenschaften (Traits):** Jeder Fahrer hat 1-3 einzigartige Eigenschaften, die das Gameplay beeinflussen.
  - *Status:* Nicht begonnen
  - *Mechanik:* Traits können positiv (z.B. "Regenmeister", "Reifenflüsterer") oder negativ (z.B. "Hitzkopf", "Inkonsistent") sein und beeinflussen die Performance unter bestimmten Bedingungen oder die Abnutzung des Materials.
  - *Entdeckung:* Traits werden durch Scouting oder durch das Verhalten des Fahrers im Laufe der Zeit aufgedeckt.

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

- **Experimentelle Projekte:** Einmal pro Saison kann ein hochriskantes Projekt gestartet werden.
  - *Mechanik:* Erfordert hohe Investitionen (Geld, Personal) für eine Chance auf einen einzigartigen Durchbruch.
  - *Mögliche Ergebnisse:* Spektakulärer, saisonübergreifender Vorteil; kostspieliger Fehlschlag mit Moralverlust; unerwartete, aber nützliche Nebeneffekte.
- **Saisonvorbereitung (F&E-Fokus):** Am Ende jeder Saison kann der Spieler einen F&E-Fokus für das Auto des nächsten Jahres festlegen.
  - *Status:* Nicht begonnen
  - *Mechanik:* Gewährt einen anfänglichen Bonus auf ein bestimmtes Bauteil oder einen Aspekt des Autos zu Beginn der neuen Saison, geht aber zu Lasten anderer Bereiche.
  - *Fokus-Optionen:* Aero-Konzept, Mechanischer Grip, Zuverlässigkeit, Allrounder.
=======


### 1.3. Finanzmanagement
**Status:** In Bearbeitung
- **Sponsorenverträge:** Aushandeln von Verträgen mit verschiedenen Sponsoren.
  - *Sponsoren-Typen:* Hauptsponsor (1 pro Saison, hoher Wert, hohe Anforderungen) und Nebensponsoren (mehrere möglich, geringerer Wert).
  - *Vertrags-Struktur:* Fixe Zahlung pro Rennen, Leistungsboni (für Punkte, Podien, Siege) und Saisonziele (z.B. Konstrukteurs-WM Platz 5).
- **Sponsoren-Beziehungsmanagement:** Die Beziehung zu Sponsoren muss aktiv gepflegt werden.
  - *Zufriedenheits-Metrik:* Jeder Sponsor hat einen Zufriedenheits-Wert, der von der Einhaltung der Ziele und der allgemeinen Team-Performance abhängt.
  - *Interaktionen:* Spieler kann Berichte an Sponsoren senden (ehrlich vs. beschönigt). Sponsoren können spezielle Anfragen stellen, deren Erfüllung die Beziehung verbessert.
  - *Auswirkungen:* Hohe Zufriedenheit führt zu besseren Vertragsangeboten; niedrige Zufriedenheit kann zu Vertragsstrafen oder vorzeitigem Ausstieg führen.
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

**Status:** In Bearbeitung
=======
**Status:** Nicht begonnen

- **Moral-System:** Jeder Mitarbeiter hat einen Moral-Wert (1-100), der seine Leistung beeinflusst.
  - *Einflussfaktoren:* Teamerfolg, persönliche Gespräche, Gehalt, Gefühl der Wertschätzung. Niedrige Moral kann zu Leistungsabfall oder Kündigungswünschen führen.
- **Interne Beziehungen:** Bestimmte Personal-Paarungen können positive oder negative Synergien entwickeln.
  - *Beispiel:* Ein Renningenieur und ein Fahrer, die sich gut verstehen, schalten einen kleinen Setup-Bonus frei. Ein Konflikt zwischen Technischem Direktor und Chef-Aerodynamiker verlangsamt die F&E.


### 1.6. Spieler-Reputation
**Status:** Fortgeschritten
=======

### 1.6. Spieler-Reputation
**Status:** Nicht begonnen

- **Reputations-Archetypen:** Die Handlungen des Spielers formen seine Reputation in eine von mehreren Richtungen.
  - *Der Pragmatiker:* Bekannt für kosteneffiziente und clevere Geschäftsentscheidungen. Zieht Sponsoren an, die auf ein gutes Preis-Leistungs-Verhältnis achten.
  - *Der Innovator:* Bekannt für riskante F&E und unkonventionelle Strategien. Steigert die Moral von risikofreudigem Personal, kann aber konservative Sponsoren abschrecken.
  - *Der Fahrer-Flüsterer:* Bekannt für exzellentes Fahrermanagement und die Entwicklung von Talenten. Macht das Team für Top-Fahrer und junge Talente attraktiver.
  - *Die Loyalitäts-Legende:* Bekannt für lange Vertragstreue mit Personal und Fahrern. Erhöht die Loyalität im gesamten Team und erleichtert Vertragsverlängerungen.
- **Dynamische Auswirkungen:**
  - Beeinflusst die Art und Konditionen von Sponsorenangeboten.
  - Wirkt sich auf die Rekrutierung von Fahrern und Personal aus (bestimmte Charaktere werden von bestimmten Reputationen angezogen).
  - Schaltet einzigartige Story-Events frei, die zum Ruf des Spielers passen.


=======
=======


## 2. Das Rennwochenende
**Status:** In Bearbeitung

### 2.1. Simulation
**Status:** In Bearbeitung
- **Ansichts-Modi:** Verschiedene Perspektiven zur Beobachtung des Rennens.
  - *TV-Kamera:* Dynamische Kameras entlang der Strecke wie bei einer Fernsehübertragung.
  - *Onboard-Kamera:* Mitfahren aus der Perspektive eines beliebigen Fahrers.
  - *2D-Kartenansicht:* Taktische Übersicht aller Fahrzeuge auf der Strecke in Echtzeit.
- **Daten-Dashboard (HUD):** Anpassbare Widgets mit allen wichtigen Informationen.
  - *Live-Zeitnahme:* Klassischer Zeitenturm mit Positionen, Fahrernamen, Abständen und Rundenzeiten.
  - *Zustandsanzeigen (Spieler):* Detaillierte Anzeige für die eigenen Fahrer: Reifenzustand (%), Benzinmenge (in Runden), ERS-Ladung (%), aktuelle Pace/ERS-Modi.
  - *Wetter-Radar:* Eine Mini-Karte, die herannahenden Regen und dessen Intensität anzeigt.

### 2.2. Strategie
**Status:** Abgeschlossen
- **Setup-Abstimmung:** Anpassen des Fahrzeug-Setups während der Trainings.
  - *Parameter:* Flügel-Einstellung (Aero-Balance), Reifendruck (Grip vs. Verschleiß), Bremsbalance.
  - *Fahrer-Feedback:* Der Fahrer gibt qualitatives Feedback (z.B. "Übersteuern am Kurveneingang"), das dem Spieler hilft, das Setup zu optimieren.
- **Boxenstopp-Planung:** Erstellen von Rennstrategien vor dem Rennen.
  - *Stints:* Festlegen der Runden für Boxenstopps und der zu verwendenden Reifenmischung (Soft, Medium, Hard, Inter, Wet) für jeden Stint.
  - *Live-Anpassung:* Die Strategie kann während des Rennens als Reaktion auf Ereignisse (z.B. Safety Car) geändert werden.
- **Anweisungen während des Rennens:** Direkte Befehle an die Fahrer.
  - *Pace-Management:* `Reifen/Sprit schonen`, `Neutral fahren`, `Attackieren`. Beeinflusst Rundenzeit, Reifen- und Benzinverbrauch.
  - *ERS-Management:* Die Modi steuern den Einsatz der elektrischen Energie.
    - *Modi:* `Aufladen`, `Neutral`, `Verteidigen`, `Überholen`, `Hotlap` (nur im Qualifying).
  - *Team-Anweisungen:* Befehle, die das Zusammenspiel der Fahrer regeln.
    - `Position halten:` Weist die Fahrer an, sich nicht gegenseitig anzugreifen.
    - `Platztausch anordnen:` Weist einen Fahrer an, den Teamkollegen vorbeizulassen (riskant für die Moral).
    - `Teamkollegen helfen (DRS):` Weist einen Fahrer an, dem Teamkollegen ins DRS-Fenster zu helfen.
- **Dynamisches Wetter:** Das Wetter spielt eine entscheidende Rolle.
  - *Vorhersage-Genauigkeit:* Die Wettervorhersage hat eine prozentuale Sicherheit, was strategische Risiken schafft.


### 2.3. Strecken-Charakteristiken
**Status:** Nicht begonnen
- **Mechanik:** Jede Strecke im Kalender hat 1-2 definierte Charakteristiken, die die Fahrzeug-Performance und Strategie beeinflussen.
- **Beispiele:**
  - *Power-Strecke (z.B. Monza):* Motorleistung ist der entscheidende Faktor.
  - *Abtriebs-Strecke (z.B. Monaco):* Aerodynamik-Effizienz ist entscheidend.
  - *Hoher Reifenverschleiß (z.B. Bahrain):* Zwingt zu reifenschonender Fahrweise oder zusätzlichen Boxenstopps.
  - *Höhenlage (z.B. Mexiko):* Reduziert die Motorleistung und beeinflusst die Kühlung.
  - *Bodenwellen (z.B. Austin):* Erfordert eine weichere Aufhängung, was die Aero-Performance beeinträchtigen kann.

=======

## 3. Spielmodi
**Status:** In Bearbeitung

### 3.1. Karriere-Modus
**Status:** In Bearbeitung

=======

- **Team erstellen:** Starte mit einem komplett neuen Team von Grund auf.
- **Bestehendes Team übernehmen:** Übernimm die Leitung eines etablierten Teams und führe es zum Erfolg.
- **Langzeit-Motivation:** Aufstieg durch verschiedene Rennserien.
=======
- **Team erstellen:** Der Spieler gründet sein eigenes Team von Grund auf.
  - *Anpassung:* Wahl von Teamname, Hauptfarbe und Logo (aus einer vordefinierten Liste).
  - *Startbedingungen:* Ein fixes Startbudget, alle Einrichtungen auf Stufe 1, ein Basis-Auto und Zugang zu einem Pool von Nachwuchsfahrern und -personal.
- **Saisonablauf:** Das Spiel schreitet in einem Kalendersystem voran.
  - *Kalender-Ansicht:* Zeigt eine Abfolge von Rennwochenenden und "HQ-Phasen".
  - *HQ-Phasen:* Zeit zwischen den Rennen für Management-Tätigkeiten (F&E, Fertigung, Personal, Finanzen, Infrastruktur-Ausbau).
- **Langzeit-Motivation:** Das ultimative Ziel ist der Gewinn der Weltmeisterschaft.
  - *Team-Prestige:* Eine neue Kennzahl, die durch Erfolge steigt. Höheres Prestige schaltet bessere Sponsoren und Personal frei und steigert die Moral.


### 3.2. Multiplayer
**Status:** Nicht begonnen
- **Online-Ligen:** Erstelle oder trete Ligen mit Freunden bei und fahre eine komplette Saison.
- **Head-to-Head:** Fordere andere Spieler zu einzelnen Rennen heraus.
- **Koop-Karriere:** Zwei Spieler leiten gemeinsam ein Team und teilen sich die Verantwortlichkeiten (z.B. einer für F&E/Finanzen, der andere für das Rennwochenende).

## 4. Sonstiges

=======

=======


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
=======

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
=======
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
=======
**Status:** In Bearbeitung

### 4.1. Fahrerakademie
**Status:** Nicht begonnen
- **Talente scouten:** Spieler können Scouts beauftragen, eine Liste von jungen Talenten (15-17 Jahre) zu erstellen. Die Genauigkeit der sichtbaren Werte und des Potenzials hängt von der Stufe der Scouting-Abteilung ab.
- **Entwicklungsfokus:** Jedem Nachwuchsfahrer kann ein Trainingsfokus zugewiesen werden (z.B. "Pace", "Konstanz", "Reifenschonung"), um gezielt Attribute zu verbessern. Die Effektivität wird durch die Simulator-Stufe beeinflusst.
- **Abschluss und Beförderung:** Mit 18 Jahren verlassen Fahrer die Akademie. Der Spieler hat ein exklusives Zeitfenster, um ihnen einen Vertrag als Stamm- oder Reservefahrer anzubieten. Danach können auch KI-Teams Angebote machen.

### 4.2. Medien & Presse
**Status:** Nicht begonnen
- Interaktion mit den Medien, die sich auf die Moral des Teams und der Fahrer auswirkt.

### 4.3. Customization
**Status:** Nicht begonnen
- Gestaltung der Team-Lackierung und Fahrerhelme.


