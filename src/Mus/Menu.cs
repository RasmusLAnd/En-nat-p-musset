using System;
using System.Collections.Generic;

namespace En_nat_p_musset
{
    class Menu
    {  
        List<ArtList> MyList = new List<ArtList>();
        List<RoomList> MyRooms = new List<RoomList>();

        int choice;
        public void EntryMenu()

        {   //Making list with ArtItems 
           
            ArtList listArt = new ArtList();
            listArt.ArtTotal(MyList);


            //Making list with All rooms      
            RoomList listRooms = new RoomList();
            listRooms.Rooms(MyRooms);

            int roomId = 0;          //setting location to "entry"    
            
            Console.Clear();
            Console.WriteLine("------------- Welcome to the musseum---------------\n"); 
            Console.WriteLine($"You have standing in the Entry\n");            
            

            do
            {   string roomNow= MyRooms[roomId].roomName;
                Console.WriteLine("Please select:");
                Console.WriteLine($"1) See all art in {roomNow} (if any)");
                Console.WriteLine("2) See connecting rooms");
                Console.WriteLine("9) To exit the program");

                int.TryParse(Console.ReadLine(), out choice);       
                Console.Clear(); 

                switch(choice)
                {    
                    case 1:
                             
                    Console.WriteLine($"The shown art in {roomNow} is:\n");
                    foreach (var item in MyList) 
                    { if(item.placedInRoom == roomId) 
                        {Console.WriteLine(item.itemName, item.artist);
                        } 
                    }
                    Console.WriteLine();
                    break;                    

                    case 2:                     
                    Console.WriteLine($"All the connecting rooms to {roomNow} are:\n");
                    foreach (var item in MyRooms) 

                        {if(item.roomID == roomId) 

                            {   
                            int firstRoom = item.connectedRoom1;
                            string nameFirst= MyRooms[firstRoom].roomName;
                            Console.WriteLine($"{nameFirst} - press {item.connectedRoom1} to enter");
                            if(item.connectedRoom2 ==9){break;}

                            int secondRoom = item.connectedRoom2;
                            string nameSecond= MyRooms[secondRoom].roomName;
                            Console.WriteLine($"{nameSecond} - press {item.connectedRoom2} to enter");
                            if(item.connectedRoom3 ==9){break;}

                            int thirdRoom = item.connectedRoom3;
                            string nameThird= MyRooms[thirdRoom].roomName;
                            Console.WriteLine($"{nameThird} - press {item.connectedRoom3} to enter");   
                            if(item.connectedRoom4 ==9){break;}

                            int fourthRoom = item.connectedRoom4;
                            string nameFourth= MyRooms[fourthRoom].roomName;
                            Console.WriteLine($"{nameFourth} - press {item.connectedRoom4} to enter");  

                                Console.WriteLine($"{item.connectedRoom4}");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("where do you want to go now?\n");
                        
                        try{
                        roomId =Int32.Parse(Console.ReadLine());
                        }
                        catch{
                            Console.WriteLine("You did not enter a correct value");
                        }                                               

                        if (roomId == 9)
                            {Console.WriteLine("this is not possible");
                            } 
                            Console.Clear();                
                    break;


                    case 9:
                    Console.WriteLine("Exit");
                    roomId =9;
                    break;

                    default:
                    break;

                }

            }while(roomId != 9);

        }
    }
}