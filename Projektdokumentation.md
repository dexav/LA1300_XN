# Projekt-Dokumentation



## 1 Informieren

### 1.1 Ihr Projekt

Random Number Guesser programmieren.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    muss             |   Funktional  | Als ein User möchte ich zufällige Zahlen erraten können, damit ich spass habe. |
| 2  |        muss         |  Funktional    | Als User möche ich, dass es einen Highscore gibt, damit ich nach jedem Spiel mich verbessern kann.                                   |
| 3 |      kann           |   Funktional   |   Als User möchte ich, dass der Highscore nach jedem Spiel angezeigt wird, damit ich keine Mühe habe es selber nachzuschauen.                               |
| 4 |      muss           | Funktional     |  Als User möchte ich, dass ich einen Hinweis dass meine Zahl zu hoch ist, damit ich es einfacher habe.                                 |
| 5  |       muss          |Funktional      |   Als User möchte ich, dass ich einen Hinweis dass meine Zahl zu klein ist, damit ich es einfacher habe.                                    |
| 6  |    muss             | Funktional     |  Als User möchte ich, wenn ich die Zahl richtig geraten habe, dass mir es mittgeteilt wird, damit ich wissen kann dass ich gewonnen habe.                         |
| 7  |    kann          | Rand | Als User möchte ich, dass am Anfang einen Namen eingeben muss, damit ich weiss wer das Spiel gespielt hat.                 |





### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | -----  | ------------ | ------------- |
| 1.1 | Programm offen|5(niedrige Zahl) |Die Zahl ist zu klein|
| 2.1 | Programm offen|90(hohe Zahl) |Die Zahl ist zu gross|
| 3.1 | Programm offen|44(richtige Zahl) |Die Zahl ist richtig|
|4.1| Programm offen|z |Falsche Eingabe|
|5.1| richtige Zahl erraten|- |SOund wird abgespielt|
|6.1| Programm offen|-|Bitte eine Zahl eingeben:|
|7.1| nach dem man die richtige Zahl erraten hat|- |Sie haben so viele Versuche gebraucht:""|
|8.1| Prgogramm wird gestartet| -|Geben Sie Ihren Namen ein:|

### 1.4 Diagramm

![Hauptprogramm 1](https://github.com/dexav/LA1300_XN/assets/110892637/94de0fe9-3363-4483-8798-ffd6e8d53874)









## 2 Planen

| AP-№ | Frist | Beschreibung | geplante Zeit |
| ---- | -----  | ------------ | ------------- |
| 1.A  | 25.08.2023        |      Udemy section 1-7        |   180min             |
| 1.B  | 25.08.2023          |   Codeacedemy anschauen           |  100 min             |
|2.A|25.08.2023|Teställe erstellen| 30 min|
|3.A|25.08.2023| Wenn man eine zu hohe Zahl rät, wird angezeigt dass die zufällige Zahl kleiner ist.|20min|
|4.A|25.08.2023| Wenn man eine zu klein Zahl rät, wird angezeigt dass die zufällige Zahl grösser ist.|20min|
|5.A|25.08.2023| Wenn man die zufällige Zahl errät, dannn zeigt es an dass es richtig war|20min|
|6.A|01.09.2023| Wenn man eine falsche Eingabe macht, wird das angezeigt.|35min|
|7.A|01.09.2023| Wenn man die richtige Zahl erraten hat wird ein Soundeffekt abgespielt|45min|
|8.A|25.08.2023|Wenn man das Programm startet, wird man hingewiesen eine Zahl einzugeben|15min|
|9.A|01.09.2023| Wenn man die richtige Zahl erraten hat, wird angezeigt wie viele Versuche man gebraucht hat.|20 min|
|10.A|01.09.2023|Wenn das Programm geöffnet wird, wird man nach dem Namen gefragt.|15 min|





  


Total: 


## 3 Entscheiden

Ich habe mich entschieden doch keinen Soundeffekt einzufügen.

## 4 Realisieren

| AP-№ | Datum | geplante Zeit | tatsächliche Zeit |
| ---- | ----- |  ------------- | ----------------- |
| 1.A  |   25.08.2023      |  180min         |    170min           |                   
| 1.B  |     25.08.2023    |   100min        |    60min           |                   
| 2.A|     25.08.2023      |  30min         |         30min      |                   
|3.A  |     25.08.2023     |       20min    |     25min         |                   
|4.A  |     25.08.2023     |     20min      |       25min         |                   
|5.A  |     25.08.2023     |     20  min      |      30 min         |                   
|6.A  |     01.09.2023     |     35 min      |     45min         |                   
|7.A  |     01.09.2023     |     45 min      |    -           |                   
|8.A  |     01.09.2023     |   15 min        |     10 min          |                   
|9.A  |     01.09.2023     |   20  min        |     30 min          |                   
|10.A  |     01.09.2023     | 15 min          |        20 min       |   

### 4.1 Plagiat / Quellen

 Bei der Methode  ``` public bool MakeGuess() ``` habe ich bei ChatGPT nachgefragt warum es nicht ging(Vorher war die Methode kein bool). Er hat mir den gleichen Code generiert, den ich geschrieben habe, aber er hat es zu einem bool gemacht, damit man aus dieser Methode rauskommt.

 Bei diesen 3 Linien Code:
```C#
  Console.Write("Bitte rate eine Zahl zwischen 0 und 100: ");
    string input1 = Console.ReadLine();
    int input = Convert.ToInt32(input1);
```
 habe ich auch von ChatGPT generieren lassen, da ich Probleme hatte wie man Console.ReadLine zu einem int konventieren konnte.                

## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1 |08.09.2023 |OK |Xavier Nursiwat|
| 2.1 |08.09.2023 |OK|Xavier Nursiwat|
| 3.1 | 08.09.2023|OK|Xavier Nursiwat|
| 4.1 |08.09.2023 |OK|Xavier Nursiwat|
| 5.1 |08.09.2023 |NOk|Xavier Nursiwat|
| 6.1 |08.09.2023 |OK|Xavier Nursiwat|
| 7.1 |08.09.2023 |OK|Xavier Nursiwat|
| 8.1 |08.09.2023 |OK|Xavier Nursiwat|




## 6 Auswerten

Portfolio: https://portfolio.bbbaden.ch/view/view.php?id=31572
