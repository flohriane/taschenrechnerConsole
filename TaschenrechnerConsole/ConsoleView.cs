﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenrechnerConsole
{

    class ConsoleView

    {
        private RechnerModel model; // Attribut

        // Konstruktor initialisiert das Attribut this.model mit dem Parameter model aus der Klasse RechnerModel
        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }

        // Property (Eigenschaft) zu Eingabedaten von Console

        // public string WertAlsString { get; private set; } - Kurzschreibweise

        private string wertAlsString;   // Attribut ist immer private

        public string WertAlsString     // Eigenschaft ist public und kommuniziert nach außen 
        {
            get { return wertAlsString; }
            set { wertAlsString = value; }
        }

        // Konstruktor, der die Eigenschaft WertAlsString initialisiert
        public ConsoleView()
        {
            WertAlsString = "default";
        }

        //Methode zum Einlesen von Zeichenkette
        public void HoleBenutzerEingabe(string ausgabeText)
        {
            Console.WriteLine(ausgabeText);
            WertAlsString = Console.ReadLine();
            Console.WriteLine();
        }

        // Methode zum Ausgeben einer Fehlermeldung
        public void GebeEingabeFehlerAus(string fehlerquelle, string eingabe)
        {
            Console.WriteLine("Dies ist eine falsche Eingabe {0}: {1}", fehlerquelle, eingabe);
            Console.WriteLine();
        }

        // Methode zum Ausgeben des Resultats
        public void GebeResultatAus(string operation)
        {
            Console.WriteLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe beträgt: {0}", model.Resultat);
                    break;

                case "-":
                    Console.WriteLine("Die Differenz beträgt: {0}", model.Resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt beträgt: {0}", model.Resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Quotient beträgt: {0}", model.Resultat);
                    break;

                default:
                    // Fehlermeldung ausgeben mit Übergabe der Fehlerquelle und der falschen Eingabe
                    GebeEingabeFehlerAus("für Operator", operation);
                    break;
            }
        }
    }
}