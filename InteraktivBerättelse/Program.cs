using System;


string choice = "";

Console.WriteLine("Du väcks av en explosion. Du blir nyfiken och tar dina glasögon. Du drar isär gardinerna. Ett hål har skapats!");
Console.WriteLine("På din högra sida har du instruktioner: \"KOM IHÅG: BLÅ ÄR KAMRATER, RÖD SKA BORT\"");
Console.WriteLine("Till höger finns dörren som leder dig till hålet.");
Console.WriteLine("Följer du korridoren rakt framåt så kommer du till stadens arsenal, där all utrustning finns.");
Console.WriteLine("Vart går du? Framåt eller höger?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "framåt")
{
  Console.WriteLine("Du kommer till stadens arsenal. Det finns få gevär kvar och en knapp?.");
  Console.WriteLine("Du låter dina känslor vinna och klickar på knappen.");
  Console.WriteLine("Ett hål öppnas under dig och en raket förbereder sig för avvikning.");
  Console.WriteLine("Raketen byter riktning och ser ut att träffa RÖD BAS.BOOM!!!");
  Console.WriteLine("RÖD BAS blev besegrade och du lever. Du börjar undra varför militären inte klicka på knappen tidigare och nu kommer du leva med nyfikenhet tills döden fångar dig.");
}
else if (choice == "höger")
{
  Console.WriteLine("Du når till hålet utan utrustning eller vapen bara en dröm.");
  Console.WriteLine("Fiender rör sig mot dig med vapen, dina kamrater stoppar inte utan motstånd men det är inte tillräckligt för att stoppa motståndarna.");
  Console.WriteLine("På mattan nedanför dig finns det understruckna bokstäver. \"NÖDSITUATION\"");
  Console.WriteLine("Under mattan finns två knappar. En röd, en grön. Det finns inget som kännetecknar \"ja\" eller \"nej\".");
  Console.WriteLine("Trycker du på röd eller grön knapp?");

  choice = Console.ReadLine();
  choice = choice.ToLower();

  if (choice == "röd")
  {
    Console.WriteLine("Utmärkt! Du kom ihåg att statsministern var färgblind så du valde röd istället för grön");
    Console.WriteLine("Alla dina kamrater återupplivades och är tillbaka i kriget. KRIGA PÅ!");
  }
  else if (choice == "grön")
  {
    Console.WriteLine("BOOM!!! Tyvär tänkte du logiskt och självförstördes samt döda fler kamrater funt omkring dig.");
    Console.WriteLine("Du är död och RÖD BAS överfördes av fiender.");
  }
  else
  {
    Console.WriteLine("Hur tänkte du! Du skrev inget jag kunde förstå, så nu blev du skjuten bakifrån.");
  }
}
else
{
  Console.WriteLine("Hur tänkte du! Du skrev inget jag kunde förstå, så nu blev du skjuten bakifrån.");
}

Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();