using System;
using System.Net;
using System.Reflection.Metadata;

String AnswerOne;


//Start//
Console.WriteLine("Hej Främling!");
  Console.ReadLine();
Console.WriteLine("Har du hört talas om Legenden om den stora runda katten Rhekredeiw Znofla Roinuj?");

AnswerOne = Console.ReadLine();
AnswerOne = AnswerOne.ToLower();



//Story background//
if (AnswerOne == "nej")
{ 
    Console.WriteLine("-Bra då ska jag berätta historian om Rhekredeiw Znofla Roinuj.");
   Console.ReadLine();
    Console.WriteLine("-Rhekredeiw Znofla är den andra av sitt namn, Förstfödd och den ända mannen i sin kull.");
   Console.ReadLine();
    Console.WriteLine("-Rhekredeiw Znofla bodde i ett litet hus i fattigdom med sin Mamma, Morbror och hans 3 yngre systrar.");
   Console.ReadLine();
    Console.WriteLine("-Som barn blev Rhekredeiw tappad ett par gågner så han utvecklade en hjärnskada som gjorde att han inte kunde kontrollera sina känslor, han hade också ett stort kontroll behov vilket gjorde att Rhekredeiw alltid slog sin familj och redan vid 1 års ålder tog han över som mannen i huset.");
   Console.ReadLine();
    Console.WriteLine("-Inte långt efter detta så blev Rhekredeiw gammal nog att flytta hemifrån, livet ute var inte lätt för honom eftersom alla blev skrämd utav hans mullighet.");
   Console.ReadLine();
    Console.WriteLine("-Så Rhekredeiw gick in i divala");
   Console.ReadLine();
    Console.WriteLine("-Det sägs att han gömmer sig norr i stan och att om man ger han mat så får man tur livet ut.");
   Console.ReadLine();
 Console.WriteLine("klicka Enter för att fortsätta....");

    Console.ReadLine();

    
     //No Story background//
} 
 else if (AnswerOne == "ja")
{
     Console.WriteLine("Oj du behöver inte vara så taskig.");

  Console.ReadLine(); 
  int.Parse("no");
} else
//Steg två i historian//
String AnswerTwo;

Console.WriteLine("Du har nu fått reda på information om Rhekredeiw Znofla Roinuj, Du kan nu välja om du vill gå till hans lya eller inte");

Console.WriteLine("Skriv ja om du vill gå dit");

Console.WriteLine("Skriv nej om du inte vill gå dit");

//Fortsättning på historian//


AnswerTwo = Console.ReadLine();
AnswerTwo = AnswerTwo.ToLower();
String AnswerTre =" ";

if (AnswerTwo == "ja")
{
    Console.WriteLine("När du anländer till platsen så ser du ett stort hål i bergsväggen, du väljer att gå in och bemöts direkt av ett fasansfullt ljud djupare i grottan. Du ser två stora lysande ögon som stirrar in i din själ. ");
      Console.ReadLine();
    Console.WriteLine("Odjuret närmar dig, vad gör du?");
    Console.WriteLine(" __________________________________");
    Console.WriteLine(":                                  :");
    Console.WriteLine(":             Spring               :");
    Console.WriteLine(":                                  :");
    Console.WriteLine(":__________________________________:");
    Console.WriteLine(" __________________________________");
    Console.WriteLine(":                                  :");
    Console.WriteLine(":             Stanna               :");
    Console.WriteLine(":                                  :");
    Console.WriteLine(":__________________________________:");

    AnswerTre = Console.ReadLine();
    AnswerTre = AnswerTre.ToLower();
}  
//Ännu ett slut på historian//
String AnswerFour =" ";

if (AnswerTre == "spring")
{
    Console.WriteLine("Du undandlydde besten. Du kommer troligtvis inte återvända");

 int.Parse("no");
}
//Fortsättning på historian//
if (AnswerTre == "stanna")
{
    Console.WriteLine ("Besten gör ett stor jaaam du inser att det endast är en stor fluffig katt");
      Console.ReadLine();
      Console.WriteLine("Katten ser hungrig ut");
      Console.WriteLine("Du har 4 föremål på dig, vilket väljer du att använda mot katten.");
      Console.WriteLine("_INVENTORY______________");
     Console.WriteLine("|                        |");
     Console.WriteLine("|       Mobil            |");
     Console.WriteLine("|       Svingod öl       |");
     Console.WriteLine("|       Kattgodis        |");
     Console.WriteLine("|       Cowboy hatt      |");
     Console.WriteLine("|                        |");
      Console.WriteLine("________________________");

      AnswerFour = Console.ReadLine();
    AnswerFour = AnswerFour.ToLower();
}
//Alternativt avslut//
if (AnswerFour == "mobil")
{
    Console.WriteLine("Katten tar mobilen och ringer polisen");
    Console.WriteLine("Spelet är slut");
    int.Parse("no");
}
//Historians rätta avslut//
if (AnswerFour == "svingod öl")
{
    Console.WriteLine("Du och katten njuter av en asgod öl");
    Console.WriteLine("Du och Rhekredeiw är nu polare! bra jobbat du klarade ut spelet.");
    int.Parse("no");
}
//Alternativt avslut//
if (AnswerFour == "kattgodis")
{
    Console.WriteLine("Du tar fram kattgodis påsen som du har i din ficka. Rhekredeiw pupiller vidgar och blir kolsvarta");
    Console.WriteLine("Rhekredeiw attackar dig");
    Console.WriteLine("Du dog");
    int.Parse("no");
}

//Alternativt avslut//

if (AnswerFour == "Cowboy hatt")
{
    Console.WriteLine("Du ger katten din hatt. Katten tittar på dig och nickar");
    Console.WriteLine("katten accepterar dig men vill att du ska lämna");
}


//Ännu ett avslut på historian//
if (AnswerTwo == "nej")
{
    Console.WriteLine("Du bestämmer dig för att stanna, Spelet är slut...");
    int.Parse("no");
}


Console.ReadLine();
