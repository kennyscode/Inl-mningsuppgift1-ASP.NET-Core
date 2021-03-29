•För Asp.Net förklaringen är det fokus på det som sker i Startup.cs, wwwroot och Razor språket.

Startup.cs innehåller kod som bestämmer hur webbapplikationen ska fungera, det är här vi konfiguerar hur webb-appen ska ta hand om inkommande requests från View (det som är synligt och intergrerbart för användaren). Wwwroot är mappen där man placerar statiska filer, exempelvis rena html-filer, JavaScript-filer, och CSS-filer som man vill använda sig av i webb-appen. Det är alltså saker som ser likadana ut varje gång en användare frågar efter det. Razor språket är en syntax skapad för ASP.NET och möjliggör skapandet av dynamiska webbsidor med en kombination av html och c#.


•För Razor Pages så handlar det bara att beskriva de två filerna. Content Page och Page Model.
Content Page i Razor Pages är en cs.html-fil som är uppbygd med det såkallade "Razor". Content Pagen är det som är synligt för användaren vid anvädning av webb-appen. Page Model är det som har hand om det logiska på webb-appen, Page modellen fungerar lite som en controller i kombination med en model över de grejer man vill visa på webbappen (viewmodel).


•För MVC så är det skillnaden mellan Model, View och Controller.
Skillnaden mellan Model, View och Controller är att

Model ger definition till saker och egenskaper samt har hand om regler och logik.

View är det som är synligt och interaktions-bart för användaren av en webb-app.

Controller tar emot input/requests från webbsidans View och något av inputen eller skickar vidare den till Model. Controllern kan sägas fungera som en kommunikationskanal mellan Model och View.
