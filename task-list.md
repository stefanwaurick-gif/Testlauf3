# Aufgabenliste: Racing Manager 2026

Dieses Dokument dient der Zuweisung und Nachverfolgung von Entwicklungsaufgaben.

---

| Task ID | Feature-Bezug | Aufgabe | Zugewiesen an | Status | Coding-Prompt / Anweisung |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **G-001** | 1.1. Team-Management | Grundgerüst für das Vertragssystem | **Jonas** | To Do | Erstelle eine `Contract` Klasse/Struktur. Sie sollte Felder für `StartDate`, `EndDate`, `Salary`, `Role` (z.B. Fahrer, Ingenieur) und `PerformanceBonuses` (als Platzhalter) enthalten. |
| **A-001** | 2.2. Strategie | Basis-Framework für KI-Entscheidungen | **Maria** | To Do | Implementiere eine einfache State Machine für die KI-Team-Strategie. Mögliche Zustände: `AggressiveDevelopment`, `Balanced`, `SaveMoney`. Die Logik für den Zustandswechsel kann vorerst zufällig sein. |
| **U-001** | 3.1. Karriere-Modus | Prototyp des Hauptmenüs | **Leo** | To Do | Erstelle die UI-Szene für das Hauptmenü. Füge Buttons für "Karriere starten", "Spiel laden", "Einstellungen" und "Beenden" hinzu. Die Funktionalität muss noch nicht implementiert sein, nur die visuellen Elemente. |
| **P-001** | 2.1. Simulation | Einfache 2D-Fahrzeugphysik | **Sofia** | To Do | Erstelle eine `CarPhysics` Klasse. Implementiere eine `Update` Methode, die Position und Geschwindigkeit basierend auf Motorleistung, Luftwiderstand und Reibung auf einer geraden Strecke berechnet. |
| **B-001** | 3.1. Karriere-Modus | Basis-System für Speichern/Laden | **David** | To Do | Entwickle zwei Funktionen: `SaveGameState(state)` und `LoadGameState()`. Die Funktionen sollen ein einfaches Objekt (z.B. mit Teamname und Budget) in eine JSON-Datei serialisieren und von dort wieder deserialisieren können. |
| **G-002** | 1.1. Team-Management | Datenmodell für Personal-Attribute | **Jonas** | To Do | Erstelle in Unity ein `ScriptableObject` namens `StaffProfile`. Es soll Felder für `Name` (string), `Role` (enum), und eine Liste von `Skills` (eigene Klasse mit Skill-Name und Rating 1-20) enthalten. |
| **U-002** | 1.1. Team-Management | UI-Screen für Personalübersicht | **Leo** | To Do | Erstelle in Unity ein UI-Panel für die "Personal"-Ansicht. Entwirf ein UI-Prefab für eine Zeile, die Name, Rolle und Top-Skill eines Mitarbeiters anzeigt. Verwende Test-Daten zur Befüllung. |
| **G-003** | 1.1. Team-Management | Vertragsklasse detaillieren | **Jonas** | To Do | Erweitere die `Contract` Klasse aus G-001. Füge Felder für `BuyoutClause` (float) und eine Liste von `PerformanceBonus` Objekten hinzu. Jeder Bonus soll einen Typ (enum: Win, Podium) und einen Betrag haben. |
