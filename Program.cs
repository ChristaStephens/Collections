using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new list of strings
            var plants = new List<string>();
            plants.Add("snake");
            plants.Add("zz");
            plants.Add("pothos");
            plants.Add("money tree");

            //Iterating through the list
            //read as show one plant in a list of plants
            foreach (var plant in plants)
            {
                Console.WriteLine(plant + " ");
                //will output name of each plant individually
            }
        }
    }
}
