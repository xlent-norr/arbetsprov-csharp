# Arbetsprov C#

Detta är grunden för ett arbetsprov i C#/ASP.Net Core. Projektet är i grund och
botten ASP.Net Core MVC-mallen med visa saker bortstädade för att hålla det så
enkelt som möjligt.

Att lösa uppgiften borde ta 1-2 timmar, vill man göra mer så är det plus i kanten
men man bör inte lägga för mycket tid heller. Presentationen är inte i fokus här
utan det viktiga är att koden är sund och välstrukturerad.

Det är fritt fram att dra in nya paket från nuget eller npm. Kopieras större
stycken kod från t.ex. stackoverflow eller github så bör detta kommenteras.

Resultatet av provet kommer sen att användas som diskussionsunderlag vid nästa
intervju. Är det inte färdigt? Är det något som inte fungerar? Då kan vi diskutera
kring det åtminstone!

## Förutsättningar

Följande behöver som minst finnas installerat på utvecklingsmaskinen.

* .NET 5.0 (https://dot.net)
* Valfri text-editor (Visual Studio Code rekommenderas, https://code.visualstudio.com/)

Då .NET 5 och Visual Studio Code fungerar oavsett plattform så är det fritt fram
att göra detta på Windows, OSX eller Linux.

## Uppgift

Skapa en fork av repositoryt på github eller klona det direkt till din dator
(eller ladda ner det som en zip-fil via den gröna knappen ovan om du inte vill
använda Git).

Implementera en klass, `WeatherService`, som hämtar väderdata från yr.no på
endpointen nedan.

> https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=63.8258&lon=20.2630

Mer information om APIet finns på https://developer.yr.no/.

Exponera informationen via `WeatherApiController` och hämta detta till startsidan
via javascript.

### Bonuspoäng

Dessa är saker som man kan tänka på när man implementerar sin lösning men som
inte är strikt nödvändiga att uppfylla.

* Använd git, skriv bra commit-meddelanden.
* Använd dependency injection.
* Validera fälten på klientsidan.
* Skriv några enkla enhetstester för `WeatherService` och `WeatherContrller`.
* Strukturera koden snyggt.
* Kommentera koden där det känns rimligt (lagom är bäst).
* Lägg till egen styling (CSS) på sidan.
* Använd inte jQuery på klientsidan (jQuery är bra på många saker, men det är bra
  att visa att man kan jobba utan det också).

## Skicka in arbetsprovet

Om du gjort en fork av repositoryt så skicka länken till din kontaktperson. Om du
klonade exempel-repositoryt eller tog ner det som en zip-fil så kan du zippa ihop
det igen och skicka in.