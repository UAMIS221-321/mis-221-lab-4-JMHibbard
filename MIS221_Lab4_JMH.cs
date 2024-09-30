using System;

int whatEva = GetANumba();

Random random = new Random();
int randomRows = random.Next(8,12);

while(whatEva != 4){
    if(whatEva == 1){
        NothinGabagool();
    } else if (whatEva == 2){
        CheesyGabagool();
    } else if (whatEva == 3){
        PiggyGabagool();
    }/* catch(Exception e){
        System.Console.WriteLine(e.Message);
    }*/
    whatEva = GetANumba();
}


/*for(int i = 0; i < random; i++){
    for(int j = 1; j < random - i; j++){
        Console.Write("* ");
    }
    System.Console.WriteLine();
}*/


static void NothinGabagool(){
    for(int i = 0; i < random; i++){
        for(int j = 1; j < random - i; j++){
            System.Console.Write("* ");
        }
        System.Console.WriteLine();
    }
}


static void CheesyGabagool(){
    for(int i = 0; i < random; i++){
        for(int j = 0; j < random - i; j++){
            if(j == 0 || j == random-i-1){
                System.Console.Write("* ");
            } else if(i != 0){
                System.Console.Write("# ");
            }        
        }
        System.Console.WriteLine();
    }
}


static void PiggyGabagool(){
    for(int i = 0; i < random; i++){
        for(int j = 1; j < random - i; j++){
            //Assigning new random variable for pepperoni slices
            Random pepRand = new Random();
            int pepRand = pepRand.Next(1,random - 1);
            //
            if(j == 0 || j == random-i-1){
                System.Console.Write("* ");
            } else if(j != 0){
                System.Console.Write("# ");
            } else if(j != 0 && j == pepSpot){
                System.Console.Write("[] ");
            }
        }
        System.Console.WriteLine();
    }
}

static int GetANumba(){
    System.Console.WriteLine("What ya want? 1, 2, or 3? If you say 4, no pizza for you.");
    return int.Parse(Console.ReadLine());
}