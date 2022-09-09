string[] APImeny = { "Bullar", "Kakor", "Kaffe" };

Console.WriteLine("Välkommen till Ninas bageri!");

string meny = "";
for (int fika = 0; fika < APImeny.Length; fika++)
{
    if (fika == APImeny.Length - 1)
        meny += "och ";

    meny += APImeny[fika] + " ";
}

Console.WriteLine("Här finns " + meny);

Console.WriteLine("För att bli erbjuden den hemliga menyn säg Brownies.");