using System;
using ToDoList.Models;
using System.Collections.Generic;

public class Program
{
  static void Main()
  {
    List<Item> newList = new List<Item> { };

    Console.WriteLine("Welcome to To Do List");
    choiceFunction();

    static void choiceFunction()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string result = Console.ReadLine();
      if (result.ToLower() == "add")
      {
        addFunction();
      }
      else if (result.ToLower() == "view")
      {
        viewFunction();
      }
      else
      {
        Console.WriteLine("I didn't understand that, please enter 'add' or 'view'...");
        choiceFunction();
      }
    }

    static void addFunction()
    {
      Console.WriteLine("Please enter the description for the new item.");
      string description = Console.ReadLine();
      Item newItem = new Item(description);
      Console.WriteLine(description + " has been added to your list.");
      choiceFunction();
    }

    static void viewFunction()
    {
      List<Item> result = Item.GetAll();
      if (result.Count < 1)
      {
        Console.WriteLine("Your list is empty! Have a great day!");
        choiceFunction();
      }
      else
      {
        foreach (Item thisItem in result)
        {
          Console.WriteLine("* " + thisItem.Description);
        }
        choiceFunction();
      }
    }
  }
}