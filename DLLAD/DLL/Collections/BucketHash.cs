using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    // Klasse gemaakt door: Frans Orsel
    // Source: Datastructures & Algorithms in C# door Michael McMillan

    // Het genereren van een aparte klasse zodat er een string wordt geleverd voor het creëren van de buckethash
    public class HashNode<T>
    {
        public T item { get; set; }
        public string value { get; set; }
        public int count { get; set; }

        // Dit is een methode om een HashNode te genereren. De methode heeft daarvoor een item nodig en een value. Met de value
        // kan de HashNode later beter opgezocht worden, en behoud de hashnode zijn status als 'generic'.
        public HashNode(T Item, string Value)
        {
            item = Item;
            value = Value;
            count = 0;
        }
    }

    // Dit is de eigenlijke buckethash klasse
    public class BucketHash<T> where T : IComparable
    {
        // De size krijgt een vaste waarde. Deze wordt gebruikt om de Arraylist data van een grootte te voorzien.
        private const int SIZE = 101;

        ArrayList[] data;

        // De initiatie van deze klasse. Hiermee wordt de klasse als eerste gemaakt.
        public BucketHash()
        {
            data = new ArrayList[SIZE];
            for(int i = 0; i <= SIZE-1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }

        // De hashmethode. In dit geval is dit een buckethash.
        public int Hash(string s)
        {
            long tot = 0;

            char[] charray;
            charray = s.ToCharArray();              // Hier wordt de string uitgestreken over de hiervoor geinitieerde array.
            for(int i=0; i <= s.Length-1; i++)      
            {
                tot += 37 * tot + (int)charray[i];  // Op dit moment in de code wordt voor elke arrayplaats de arrayplaats voorzien van een hash
            }                                       // getal, en wordt dat toegevoegd aan het totaal : 'tot'
            tot = tot % data.GetUpperBound(0);      // Hier wordt het 'tot' getal verkleind tot een handzamere grote
            if (tot < 0)                            // Voor error afhandeling wordt dan toch gekeken of het totaal minder dan 0 is. Is dat het 
            {                                       // geval, wordt de maximale grootte toegevoegd aan het totaal.
                tot += data.GetUpperBound(0);
            }
            return (int)tot;
        }

        // Deze methode voegt een item toe aan de buckethash. Het gebruikt daarvoor de hieropvolgende Insert methode.
        public void AddItem(T item, string value)
        {
            HashNode<T> Node = new HashNode<T>(item, value);
            Insert(Node);
        }

        // De insertmethode is waarom dit een buckethash is. Deze methode kijkt of de plaats met het hash getal al bezet is, en voegt hem dan 
        public void Insert(HashNode<T> item)    // aan dezelfde plaats toe.
        {
            int hash_value;
            hash_value = Hash(item.value);
            if (data[hash_value].Contains(item.value))
            {
                data[hash_value].Add(item);
            }
        }
    }
}
