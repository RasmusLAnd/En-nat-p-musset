using System;
using System.Collections.Generic;

namespace En_nat_p_musset
{
    public class ArtList
    {
        public string itemName, artist; 
        public int placedInRoom;

        public void SetArt(string ItemName, string Artist, int ID)
        {
            this.itemName = ItemName;
            this.artist = Artist;
            this.placedInRoom = ID;

        }

        public List<ArtList> ArtTotal(List<ArtList> MyList)
        {   

            //Entry - nothing
            var ItemZero = new ArtList();
            string ItemName0 = "This room is empty", Artist0 =  "";
            int ID0 = 0; 
            ItemZero.SetArt(ItemName0, Artist0, ID0);
            MyList.Add(ItemZero);  

            //corridor - nothing
            var ItemC = new ArtList();
            string ItemNameC = "This room is empty", ArtistC =  "";
            int IDC = 1; 
            ItemC.SetArt(ItemNameC, ArtistC, IDC);
            MyList.Add(ItemC);  

            //Green room  
            var ItemOne = new ArtList();
            string ItemName = "Art1", Artist =  "John Petersen";
            int ID = 2; 
            ItemOne.SetArt(ItemName, Artist, ID);
            MyList.Add(ItemOne);  
            
            var Item2 = new ArtList();
            string ItemName2 = "Art2", Artist2 =  "John Petersen";
            int ID2 = 2; 
            Item2.SetArt(ItemName2, Artist2, ID2);
            MyList.Add(Item2);

            //Red room
            var Item3 = new ArtList();
            string ItemName3 = "Art3", Artist3 =  "John Petersen";
            int ID3 = 3; 
            Item3.SetArt(ItemName3, Artist3, ID3);
            MyList.Add(Item3);

            var Item4 = new ArtList();
            string ItemName4 = "Art4", Artist4 =  "John Petersen";
            int ID4 = 3; 
            Item4.SetArt(ItemName4, Artist4, ID4);
            MyList.Add(Item4);

            var Item5 = new ArtList();
            string ItemName5 = "Art5", Artist5 =  "John Petersen";
            int ID5 = 3; 
            Item5.SetArt(ItemName5, Artist5, ID5);
            MyList.Add(Item5);

            //purple room
            var Item6 = new ArtList();
            string ItemName6 = "Art6", Artist6 =  "John Petersen";
            int ID6 = 4; 
            Item6.SetArt(ItemName6, Artist6, ID6);
            MyList.Add(Item6);

            var Item7 = new ArtList();
            string ItemName7 = "Art7", Artist7 =  "John Petersen";
            int ID7 = 4; 
            Item7.SetArt(ItemName7, Artist7, ID7);
            MyList.Add(Item7);

            var Item8 = new ArtList();
            string ItemName8 = "Art8", Artist8 =  "John Petersen";
            int ID8 = 4; 
            Item8.SetArt(ItemName8, Artist8, ID8);
            MyList.Add(Item8);

            var Item9 = new ArtList();
            string ItemName9 = "Art9", Artist9 =  "John Petersen";
            int ID9 = 4; 
            Item9.SetArt(ItemName9, Artist9, ID9);
            MyList.Add(Item9);

            //blue room
            var Item10 = new ArtList();
            string ItemName10 = "Art10", Artist10 =  "John Petersen";
            int ID10 = 5; 
            Item10.SetArt(ItemName10, Artist10, ID10);
            MyList.Add(Item10);

            //black room - nothing
            var ItemB = new ArtList();
            string ItemNameB = "This room is empty", ArtistB =  "";
            int IDB = 6; 
            ItemB.SetArt(ItemNameB, ArtistB, IDB);
            MyList.Add(ItemB);


            //White room
            var Item11 = new ArtList();
            string ItemName11 = "Art11", Artist11 =  "John Petersen";
            int ID11 = 7; 
            Item11.SetArt(ItemName11, Artist11, ID11);
            MyList.Add(Item11);

            return MyList;
        }

        
    }
    public class RoomList{
        public string roomName; 
        public int roomID, connectedRoom1, connectedRoom2, connectedRoom3, connectedRoom4;

        public void SetRoom(string RoomName, int ConnectedRoom1,int ConnectedRoom2,int ConnectedRoom3,int ConnectedRoom4, int RoomID)
        {
            this.roomName = RoomName;
            this.roomID = RoomID;
            this.connectedRoom1 = ConnectedRoom1;
            this.connectedRoom2 = ConnectedRoom2;
            this.connectedRoom3 = ConnectedRoom3;
            this.connectedRoom4 = ConnectedRoom4;

        }
        public List<RoomList> Rooms(List<RoomList> MyRooms)
        {
            //Entry  
            var RoomItem = new RoomList();
            string RoomName  = "Entry";            
            int RoomId = 0, 
            ConnectedRoom1 = 1,  
            ConnectedRoom2 = 9,            
            ConnectedRoom3 = 9, 
            ConnectedRoom4 = 9; 

            RoomItem.SetRoom(RoomName, ConnectedRoom1, ConnectedRoom2, ConnectedRoom3,ConnectedRoom4,RoomId);
            MyRooms.Add(RoomItem);

            //Corridor 

            var RoomItem1 = new RoomList();
            string RoomName1  = "Corridor";            
            int RoomId1 = 1, 
            ConnectedRoom11 = 0,  
            ConnectedRoom21 = 2,            
            ConnectedRoom31 = 9, 
            ConnectedRoom41 = 9; 

            RoomItem1.SetRoom(RoomName1, ConnectedRoom11, ConnectedRoom21, ConnectedRoom31,ConnectedRoom41,RoomId1);
            MyRooms.Add(RoomItem1);  

            //GreenRoom

            var RoomItem2 = new RoomList();
            string RoomName2  = "Green Room";            
            int RoomId2 = 2, 
            ConnectedRoom12 = 1,  
            ConnectedRoom22 = 3,            
            ConnectedRoom32 = 5, 
            ConnectedRoom42 = 9; 

            RoomItem2.SetRoom(RoomName2, ConnectedRoom12, ConnectedRoom22, ConnectedRoom32,ConnectedRoom42,RoomId2);
            MyRooms.Add(RoomItem2);  

             //Red room

            var RoomItem3 = new RoomList();
            string RoomName3  = "Red Room";            
            int RoomId3 = 3, 
            ConnectedRoom13 = 1,  
            ConnectedRoom23 = 3,            
            ConnectedRoom33 = 5, 
            ConnectedRoom43 = 9; 

            RoomItem3.SetRoom(RoomName3, ConnectedRoom13, ConnectedRoom23, ConnectedRoom33,ConnectedRoom43,RoomId3);
            MyRooms.Add(RoomItem3);

             //Purple room

            var RoomItem4 = new RoomList();
            string RoomName4  = "Purple Room";            
            int RoomId4 = 4, 
            ConnectedRoom14 = 3,  
            ConnectedRoom24 = 5,            
            ConnectedRoom34 = 9, 
            ConnectedRoom44 = 9; 

            RoomItem4.SetRoom(RoomName4, ConnectedRoom14, ConnectedRoom24, ConnectedRoom34,ConnectedRoom44,RoomId4);
            MyRooms.Add(RoomItem4);

            //blue room

            var RoomItem5 = new RoomList();
            string RoomName5  = "Blue Room";            
            int RoomId5 = 5, 
            ConnectedRoom15 = 2,  
            ConnectedRoom25 = 4,            
            ConnectedRoom35 = 6, 
            ConnectedRoom45 = 7; 

            RoomItem5.SetRoom(RoomName5, ConnectedRoom15, ConnectedRoom25, ConnectedRoom35,ConnectedRoom45,RoomId5);
            MyRooms.Add(RoomItem5);

            //black room
            var RoomItem6 = new RoomList();
            string RoomName6  = "Black Room";            
            int RoomId6 = 6, 
            ConnectedRoom16 = 5,  
            ConnectedRoom26 = 9,            
            ConnectedRoom36 = 9, 
            ConnectedRoom46 = 9; 

            RoomItem6.SetRoom(RoomName6, ConnectedRoom16, ConnectedRoom26, ConnectedRoom36,ConnectedRoom46,RoomId6);
            MyRooms.Add(RoomItem6);

            //white room
            var RoomItem7 = new RoomList();
            string RoomName7  = "White Room";            
            int RoomId7 = 7, 
            ConnectedRoom17 = 5,  
            ConnectedRoom27 = 9,            
            ConnectedRoom37 = 9, 
            ConnectedRoom47 = 9; 

            RoomItem7.SetRoom(RoomName7, ConnectedRoom17, ConnectedRoom27, ConnectedRoom37,ConnectedRoom47,RoomId7);
            MyRooms.Add(RoomItem7);
        
        return MyRooms;
        }

    }
}