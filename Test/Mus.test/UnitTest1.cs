using System;
using Xunit;
using System.Collections.Generic;

namespace test
{
    public class MussemTest
    {
        [Fact]
        public void ArtListLength()
        {
        //arrange
        
        List<ArtList> MyList = new List<ArtList>();

        //act
         int lenght = MyList.Count;

        //assert
         Assert.Equal(14, lenght);
        }


        [Fact]
        public void RoomListLength()
        {
        //arrange
        List<RoomList> MyRooms = new List<RoomList>();

        //act
         int lenght = MyRooms.Count;

        //assert
         Assert.Equal(8, lenght);
        }

        [Fact]
        public void LastTest()
        {
        //arrange
        List<ArtList> MyList = new List<ArtList>();
        

        //act
        string nameOfArt1 = MyList[2].itemName;

        //assert
         Assert.Equal("Art1", nameOfArt1);
        }



    }
}
