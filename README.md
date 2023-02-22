# DT191G Webbutveckling med .NET / Christine Johanson chjo2104
## Laboration 4 Webbtjänster

### Uppgiften:
Skapa en API/REST-webbtjänst med ASP.NET Core.

### Obligatoriska delar:
- Skapa ett API med ASP.NET Core som hanterar en låtlista och denna låtlista ska innehålla följande data: 
* Artist
* Låt-titel
* Spel-längd i sekunder
* Kategori
- API´et ska presentera data i JSON-format. 
- API´et ska ha full CRUD-funktionalitet och det ska kunna visas med t.ex Thunder Client.
- Datan lagras i valfri databasserver. 

### Plus-uppgift:
- API´et ska inte vara ett minimalt API, utan använda Controller.
- Databasen innehåller minst två tabeller.

#### Resultat
API/REST-webbtjänst är skapad med ASP.NET Core. Den innehåller en låtlista där information om artist, låttitel, spellängd och kategori läses ut. För plusuppgift har jag även skapat en tabell för album, så albuminformation läses också ut.

API´et är inte ett minimalt sådant, utan skapat med Controllers. 

Via ThunderClient testas API´et så att det har full CRUD-funktionalitet. 

Datan lagras i databasserver SQLite.

Uppbyggnad API:

| Metod | Ändpunkt | Beskrivning |
| --- | --- | --- |
| GET | /api/song | hämtar alla låtar |
| GET | /api/song/1 | hämtar song med angivet ID |
| POST | /api/song | lagrar ny låt |
| PUT | /api/song/1 | uppdaterar låt med angivet ID |
| DELETE | /api/song/1 | raderar låt med angivet ID |

### Länk till publicerad demonstration av projektet:
[Demonstration]()
