class Program{
    static void Main (string[] args){

        Console.WriteLine ("Plz input Day : ");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine ("Plz input Time : ");
        int time = int.Parse(Console.ReadLine());

        int breakfastSet = 5 ;
        int weekendSet = 2 ;
        int coffee = 3 ;

        Console.WriteLine ("Plz order your meal : ");

        while( breakfastSet >= 0 || weekendSet >= 0 || coffee >= 0 ){

            
             string meal = Console.ReadLine();

            if(meal == "Breakfast Set" ){
                
                if (time < 11){
                    if(breakfastSet > 0){
                        breakfastSet--;
                    }else{
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                }else{
                    Console.WriteLine("Sorry your order is not avaliable");
                }

            }else if(meal == "Weekend Set" ){
                if(day >= 6){
                    if( weekendSet > 0){
                    weekendSet--;
                    }else{
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                }else{
                    Console.WriteLine("Sorry your order is not avaliable");
                }

            }else if(meal == "Coffee" ){
                if( coffee > 0){
                    coffee--;
                }else{
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                
            }else if(meal == "End"){
                break;
            }
            else{
                Console.WriteLine("Please enter a valid menu");
            }
        }
        
    }
}