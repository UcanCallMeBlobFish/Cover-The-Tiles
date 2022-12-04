Boolean[] tiles = new bool[10]; 
int[] credit = new int[2];
int[] randomnumbers = new int[2];
int[] userinputs = new int[4];
Array.Fill(tiles,true);
Random rand = new Random();
int round = 0;


while (round < 10) {
    for (int i = 0; i < randomnumbers.Length; i++) {
        randomnumbers[i] = rand.Next(1, 10);
    }
    Console.WriteLine("Player 1 numbers:");
    Console.WriteLine(randomnumbers[0]);
    Console.WriteLine(randomnumbers[1]);
    Console.WriteLine("Open tiles are:");
    
    for (int i = 0; i < tiles.Length; i++)
    {
        Console.Write(" "+ (i+1) + ")" + tiles[i]);
        
    }
    
    

        // tiles.ToList().ForEach(t => Console.Write(" " + t.ToString()));

    for (int k = 1; k < 2; k++) { // loop to exchange roles between player 1 and 2 (array indices).
        
        Console.WriteLine("\nWhich tiles to cover by player "+ "" + k + "" + "? (0 for no valid combination)");
        
        Console.WriteLine("Title 1");
        userinputs[0] = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Title 2");
        userinputs[1] = Convert.ToInt32(Console.ReadLine());
        
        while (userinputs[0] > 10 || userinputs[0] < 0 || userinputs[1] > 10 || userinputs[1] < 0) {  // loop for invalid inputs.
            Console.WriteLine("Title 1");
            userinputs[0] = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Title 2");
            userinputs[1] = Convert.ToInt32(Console.ReadLine());
        }
        
        if (userinputs[0] == 0 || userinputs[1] == 0) {   // if user input is x0=0x then add all open tiles to its ballance.
            for (int i = 0; i < tiles.Length; i++) {
                if (tiles[i] == true) {
                    credit[k] += i;    
                }
            }
        }
        else
        {
            tiles[userinputs[0] -1 ] = false;
            tiles[userinputs[1] -1 ] = false;
        }
        
        if (!tiles.Contains(true))
        {
            Console.WriteLine(k + "is winner");
            break;
        }
    }
    round++;
}

if (credit[0] > credit[1])
{
    Console.WriteLine("winner is: 1");
}
else
Console.WriteLine("winner is: 0");