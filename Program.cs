using System;
using System.Collections.Generic;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //gezginler
            MyDictionary<int, string> gezginler = new MyDictionary<int, string>();

            gezginler.Add(1, "Nazan");
            gezginler.Add(2, "Firuzan");
            Console.WriteLine(gezginler.Lengh);  //kendi yazıdğımız Lenght

            //foreach (KeyValuePair<TKey,TValue> kvp in ogrenciler)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            //}


            //Earth’s Continent - Countries by continent
            //step-1: Kıtaların Listesi
            //bkz. https://simple.wikipedia.org/wiki/List_of_countries_by_continents
            //bkz. https://www.geosociety.org/gsatoday/archive/27/3/article/GSATG321A.1.htm (Zealandia: Earth’s Hidden Continent)

            MyDictionary<int, string> continents = new MyDictionary<int, string>();
            Console.WriteLine("List of countries by continents");
            continents.Add(1, "Africa");
            continents.Add(2, "Antarctica");
            continents.Add(3, "Asia");
            continents.Add(4, "Europe");
            continents.Add(5, "North America");
            continents.Add(6, "South America");
            continents.Add(7, "Australasia/Oceania");
            continents.Add(8, "Zealandia");


            Console.WriteLine(continents.Lengh);  //kendi yazıdğımız Lenght


            //step-2: Kıtalar -Ülke İsimleri
             MyDictionary<string, string> countries = new MyDictionary<string, string>();
            //Africa
            countries.Add("Africa", "Angola, Batı Sahra , Benin, Botsvana , Burkina Faso, Burundi, Cezayir, " +
                "Cibuti, Çad,Kongo DC, Ekvator Ginesi, Eritre, Etiyopya, Fas, Fildişi Sahili, Gabon, Gambiya, Gana, Gine, Gine Bissau, " +
                "Güney Afrika Cumhuriyeti, Kamerun, Yeşil Burun Adaları, Kenya, Komorlar, Kongo Cumhuriyeti, Lesotho, Liberya, Libya, " +
                "Madagaskar, Malavi, Mali, Mauritius, Moritanya, Mozambik, Mısır, Namibya, Nijer, Nijerya, Orta Afrika Cumhuriyeti, " +
                "Ruanda, Sao Tome ve Principe, Senegal, Seyşel Adaları, Sierra Leone, Somali, Sudan, Esvatini, Tanzanya, Togo, Tunus, " +
                "Uganda, Zambiya, Zimbabve");

            //Asia
            countries.Add("Asia", "Afganistan, Azerbaycan, Bahreyn,Bangladeş, Bhutan, Birleşik Arap Emirlikleri, Brunei, Çin, Doğu Timor, " +
                "Endonezya,Ermenistan, Filipinler, Filistin, Güney Kore, Gürcistan, Hindistan, Irak, İran, İsrail, Japonya," +
                "Katar, Kazakistan, Kırgızistan, Kuzey Kore, Malezya, Nepal, Özbekistan, Pakistan, Rusya, Singapur, Sri Lanka, Suriye, Tacikistan," +
                "Tayland, Türkiye, Türkmenistan, Vietnam, Yemen");

            //Europe
            countries.Add("Europe", "Andorra, Almanya, Arnavutluk, Avusturya, Belçika, Beyaz Rusya, Birleşik Krallık, Bosna - Hersek,Bulgaristan," +
                "Çek Cumhuriyeti,Danimarka,Estonya,Faroe Adaları,Finlandiya,Fransa,Hollanda,Hırvatistan,İrlanda,İspanya,İsveç,İsviçre,İtalya," +
                "İzlanda,Karadağ,Kosova,Kuzey Kıbrıs Türk Cumhuriyeti,Letonya,Lihtenştayn,Litvanya,Lüksemburg,Macaristan,Kuzey Makedonya," +
                "Malta,Moldova,Monako,Norveç,Polonya,Portekiz,Romanya,Rusya,San Marino,Slovakya,Slovenya,Sırbistan,Türkiye,Ukrayna,Yunanistan");

            //North America
            countries.Add("North America", "ABD Virgin Adaları, Amerika Birleşik Devletleri,Antigua ve Barbuda,Aruba,Bahama,Barbados,Belize,Bermuda," +
                "Cayman Adaları,Dominika,Dominik Cumhuriyeti,El Salvador,Grenada,Grönland,Guadeloupe,Guatemala,Haiti,Hollanda Antilleri, " +
                "Honduras, Jamaika,Kanada,Kosta Rika,Küba,Martinik,Meksika,Montserrat,Nikaragua,Panama,Puerto Riko,Saint Kitts ve Nevis,Saint Lucia," +
                "Saint - Pierre ve Miquelon,Trinidad ve Tobago,Turks ve Caicos Adaları");

            //South America
            countries.Add("South America", "Bolivya,Brezilya,Fransız Guyanası,Guyana,Kolombiya,Ekvador,Paraguay,Surinam, Uruguay, Venezuela, Şili, Peru");

            //Oceania
            countries.Add("Australasia/Oceania", "Avustralya, Endonezya, Fiji, Kiribati, Marshall Adaları, Mikronezya, Nauru, Palau, Papuya Yeni Gine, Samoa, Solomon Adaları," +
                " Tonga, Tuvalu, Vanuatu, Yeni Zelanda");

            //Zealandia -Hidden Continent
            countries.Add("Zealandia", "Yeni Zealandia, Yeni Kaledonya");

            Console.WriteLine(countries.Lengh);



        }    
    }
}

