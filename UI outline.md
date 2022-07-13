


      List<Item> newList = new List<Item> { };
Program: Welcome to the To Do List.
Program: Would you like to add an item to your list or view your list? (Add/View)
console.readline result

choiceFunction()
  if result = add
    do add function
  else if result= view
    do view function

add function
  console.writeline "Please enter the description for the new item."
  string description= console.readline 
      Item newItem = new Item(description);
      console.writeline description + "has been added to your list. Would you like to add an item to your list or view your list? (Add/View)"
    choiceFunction()

view function
  check for empty
   if listitem.count < 1 return message "You list is empty, have a fantastic day!"
else if 
       foreach (Item thisItem in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisItem.Description);
       }


  }