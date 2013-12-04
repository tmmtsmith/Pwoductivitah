Pwoductivitah
=============

Extremely simple console timer for productivity sprints.  The file to edit is `Program.cs` and below are some options, depending on how sprints are to be adjusted.

###Timer

`Thread.Sleep(60000);`

60000 = 1 minute.  Program counts down in minutes, and this value can be changed to other increments.

###Beeping

`Console.Beep(1000, 800);`

Note that the beeping only lasts 800 milliseconds and beeps at a hertz of 1000.

###Program Termination

The program will loop until a user selects Y or y.  To stop this remove the below code and keep only `a = 2`:

```Console.WriteLine("Do you want to exit (Press Y or N)?");
string rep = Console.ReadLine();
if (rep.ToLower() == "y")```

###Performance

**Windows 7:** `1.4 MB Memory`
**Windows 8:** `1.2 MB Memory`
