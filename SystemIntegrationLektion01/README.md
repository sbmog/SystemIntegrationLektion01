# SystemIntegration Lektion 1

## Opgave 1: Installation af Docker

[Hent og installer Docker Desktop](https://www.docker.com/products/docker-desktop/)

Hvis I installerer på en Windows arkitektur, skal I også installere WSL som en del af installationen. Installationsguiden giver instrukser herom. 

WSL – Windows Subsystem for Linux installere Ubunto linux som default. 

[Install WSL | Microsoft Learn](https://learn.microsoft.com/en-us/windows/wsl/install)

## Opgave 2: Hent og kør RabbitMQ Docker Image

<img src="./images/dockerstart.png" alt="Docker desktop welcome screen" width="50%"/>

Når I starter Docker Desktop, vil I se et velkomstbillede som ovenstående. 
Tryk på Search images to run og søg efter "rabbitmq". Vælg det officielle RabbitMQ image med management plugin'et (Tag der -management i navnet).
Og vælg Pull.

<img src="./images/rabbitmqimage.png" alt="Docker desktop rabbitmq image" width="50%"/>

Dette skulle gerne resultere i at Docker henter RabbitMQ imaget ned til jeres lokale maskine.
Før at køre RabbitMQ imaget, kan I trykke på "Play" knappen i Docker Desktop. 

Vælg optional settings og sæt Port mapping til 5672:5672 og 8080:15692 og giv containeren et navn (f.eks. rabbitmq).

Naviger til http://localhost:8080 i jeres browser for at se RabbitMQ management konsollen. 

brugernavn og password er som default "guest" og "guest".

<img src="./images/rabbitlogin.png" alt="RabbitMQ management console" width="50%"/>

## Opgave 3: Forbind til RabbitMQ

Følg instrukserne i [RabbitMQ Getting Started Guide](https://www.rabbitmq.com/tutorials/tutorial-one-dotnet) 

for at forbinde til RabbitMQ serveren I lige har startet op i Docker.

I stedet for at bruge dotnet cli'en til at oprette projekter, kan I bruge Visual Studio ved at 
højreklikke i jeres løsning og vælge "Add" -> "New Project..." og vælge en "Console App" template.

Sørg for at vælge det rigtige sprog C# når I opretter projekter. 

<img src="./images/consoleapp.png" alt="Visual Studio new console app" width="50%"/>

Når I har oprettet jeres projekter, skal I tilføje RabbitMQ.Client NuGet pakken til begge projekter.

I finder NuGet Package Manager ved at højreklikke på jeres projekt i Solution Explorer og vælge "Manage NuGet Packages...".


