// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fraudulent Order\n");

string[] fraudulentOrderIDs = { "B123", "C234", "A345","C15", "B177", "G3003", "C235", "B179" };

foreach(string items in fraudulentOrderIDs){
    if (items.StartsWith("B")){

    Console.WriteLine(items);
    }
}