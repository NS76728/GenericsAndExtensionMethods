using Microsoft.VisualStudio.PlatformUI;
using System;
using System.IO;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        //Generics
        //TODO Create a class called "Storage" that has a generic Type "T". Set a constraint to for the type so that T must conform to IStorable.
        //TODO In your class create a property List called "Bin". Set the list type to "T".
        //TODO Create two more classes. One class called "Boxes". The second class called "Food". Both classes will conform to IStoreable interface.
        //TODO create two instances of type Storage in the Main method. First Instance will hold type "<Boxes>". The second instance will hold "<food>".
        //TODO create some instanes of type Food and Boxes and Add them to the correct storage bins.

        
        static void Main(string[] args)
        {
            var Boxes1 = new Storage<Boxes>();

            var Food1 = new Storage<Food>();

            var box1 = new Boxes();
            var box2 = new Boxes();
            var box3 = new Boxes();
            var food1 = new Food();
            var food2 = new Food();
            var food3 = new Food();

            Boxes1.Bin.Add(box1);
            Boxes1.Bin.Add(box2);
            Boxes1.Bin.Add(box3);

            Food1.Bin.Add(food1);
            Food1.Bin.Add(food2);
            Food1.Bin.Add(food3);

            var nums = new int[3];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
             ExtensionMethods.pluralize("bee");
            ExtensionMethods.SortArray(nums);
        }


        //ExtensionMethods
        //TODO Create a static class called "ExtensionMethods"
        //TODO in your new class create a static extension method called "pluralize" this method should take a string and add an s to the end of it. (***BONUS*** if string ends in y you can replace y with ies to pluralize it)

        //TODO Create an extension method called "SortArray". This method will take an array of type T. Then it will use a LINQ statement to OrderBy.
        //TODO call both extension methods in the Main. Use the method on the numbers Array.


    }
}
