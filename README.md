# Arbetsprov C#

Detta är grunden för ett arbetsprov i C#/ASP.Net Core. Projektet är i grund och
botten ASP<span>.Net Core MVC-mallen med visa saker bortstädade för att hålla det
så enkelt som möjligt.

Målet är att se hur en arbetssökande tänker kring implementationen av ett enkelt
MVC-API som hämtar information från tredje part och hur man sen kan prata kring
de val man gjorde under uppgiften.

Att lösa uppgiften borde ta 1-2 timmar, vill man göra mer så är det plus i kanten
men man bör inte lägga för mycket tid heller. Presentationen är inte i fokus här
utan det viktiga är att koden är sund och välstrukturerad.

Det är fritt fram att dra in nya paket från nuget (t.ex. Json.NET), npm eller
ta lokala referenser om så önskas.

Resultatet av provet kommer sen att användas som diskussionsunderlag vid nästa
intervju. Är det inte färdigt? Är det något som inte fungerar? Då kan vi diskutera
kring det åtminstone!

## Förutsättningar

Följande behöver som minst finnas installerat på utvecklingsmaskinen.

* .NET 6.0 (https://dot.net)
* Valfri text-editor (Visual Studio Code rekommenderas, https://code.visualstudio.com/)

Då .NET 6 och Visual Studio Code fungerar oavsett plattform så är det fritt fram
att göra detta på Windows, OSX eller Linux.

## Uppgift

Ta en kopia på projektet (forka på github, skapa
[nytt repo med detta som template](https://github.com/xlent-norr/arbetsprov-csharp/generate)
eller klona direkt till din dator). Vill du inte använda Git så kan du också ladda
ner projektet som en
[zip-fil](https://github.com/xlent-norr/arbetsprov-csharp/archive/refs/heads/main.zip).

Implementera den logik som saknas `WeatherService` för att hämta väderdata från
yr.no på endpointen nedan.

> https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=63.8258&lon=20.2630

Mer information om APIet finns på https://developer.yr.no/.

Exponera informationen via `WeatherApiController` som JSON och hämta detta till startsidan
via javascript. Presentera informationen på lämpligt sätt.

### Relevanta filer

Man får fria händer i hur man vill strukturera projektet för att uppnå resultatet.
Följande filer finns förberedda i projektet men vill man strukturera koden annorlunda
så är det fritt fram.

* src\Arbetsprov<span>.CSharp.Web\Contracts\IWeatherService.cs
* src\Arbetsprov<span>.CSharp.Web\Controllers\WeatherApiController.cs
* src\Arbetsprov<span>.CSharp.Web\Models\WeatherData.cs
* src\Arbetsprov<span>.CSharp.Web\Views\Home\Index.cshtml
* src\Arbetsprov<span>.CSharp.Web\wwwroot\js\site.js

### Vill du ha en stjärna i kanten?

Dessa är saker som vi ser positivt på om man tar hänsyn till när man implementerar
sin lösning.

* Använd git, skriv bra commit-meddelanden.
* Använd dependency injection i ASP<span>.Net Core.
* Skriv några enkla enhetstester för `WeatherService` och `WeatherController`.
* Använd en egen vy-modell mot frontend istället för YRs datamodell. 
* Felhantering både på servern och i frontend.
* Strukturera koden snyggt, skriv semantiskt korrekt html.
* Validera fälten på klientsidan.
* Kommentera koden där det känns rimligt.
* Anpassa stylingen på resultatet.
* Använd inte jQuery på klientsidan.

Har du egna idéer på hur något kan göras bättre? Visa vad du är bäst på!

### Frågor eller funderingar

Om du har frågor eller känner att något behöver förtydligas kring uppgiften så
hör av dig till din kontaktperson så får vi reda ut det.

## Skicka in arbetsprovet

Om du gjort en fork av repositoryt så skicka länken till din kontaktperson. Om du
klonade exempel-repositoryt eller tog ner det som en zip-fil så kan du zippa ihop
det igen och skicka in (om du vill skicka in en ZIP-fil men har använt git så se
till att .git-mappen följer med i ZIP-filen).
