foreach (var student in classList) {
                    if (student.name == removal) {
                        Console.WriteLine();
                        Console.WriteLine("Target has been found");    
                        Console.WriteLine();
                        int index = classList.FindIndex(a => a.name.Contains(removal));
                        Console.WriteLine(index);
                        classList.RemoveAt(index);
                        Console.WriteLine(student.name + " has been removed from your class.");
                        Console.WriteLine();
                        
                    }

                }
