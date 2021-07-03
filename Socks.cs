using System;
using System.Collections.Generic;
using System.Linq;

namespace SockPairs
{
    //the sock class will hold all of the values and the constructor that will be used for the program
    public class Sock
    {
        //the different sock variables will be used to hold the serven different sock values to generate how many pairs there are
        public int sock {get; set;} = 0;

        public int sock2 {get; set;} = 0;
        public int sock3 {get; set;} = 0;
        public int sock4 {get; set;} = 0;
        public int sock5 {get; set;} = 0;
        public int sock6 {get; set;} = 0;
         public int sock7 {get; set;} = 0;
        //The count variables will be used in the forach loops to indicate how many of each numbers there are that will indicate the sock pairs
        public int count {get; set;} = 0;
        public int count2 {get; set;} = 0;
        public int count3 {get; set;} = 0;
        public int count4 {get; set;} = 0;
        public int count5 {get; set;} = 0;
        public int count6 {get; set;} = 0;
        public int count7 {get; set;} = 0;

        //The list will hold the socks entered by the user
        public List<int> socks = new();
        //Pairs will hold the total number of pairs of socks there are
        public int pairs {get; set;} = 0;
        //Constructors
        public Sock() {}
        public Sock(int enterSock,int enterSock2,int enterSock3,int enterSock4,int enterSock5,int enterSock6,int enterSock7) 
        {
            sock = enterSock;
            sock2 = enterSock2;
            sock3 = enterSock3;
            sock3 = enterSock4;
            sock4 = enterSock5;
            sock5 = enterSock6;
            sock7 = enterSock7;
            

        }
        //This funstion will be used to display the numbers of pairs and return the pairs
        public string displayPair() 
        {
            //Add different socks to the socks list
            socks.Add(sock);
            socks.Add(sock2);
            socks.Add(sock3);
            socks.Add(sock4);
            socks.Add(sock5);
            socks.Add(sock6);
            socks.Add(sock7);
           
             //Create queries of the socks to show values of numbers entered      
            var sockPairs = (from sockpair in socks
                             where sockpair == sock
                             select sockpair).ToList();
            
            var sockPairs2 = (from sockpair2 in socks
                             where sockpair2 == sock2
                             select sockpair2).ToList();

            var sockPairs3 = (from sockpair3 in socks
                             where sockpair3 == sock3
                             select sockpair3).ToList();
            var sockPairs4 = (from sockpair4 in socks
                             where sockpair4 == sock4
                             select sockpair4).ToList();
            var sockPairs5 = (from sockpair5 in socks
                             where sockpair5 == sock5
                             select sockpair5).ToList();
            var sockPairs6 = (from sockpair6 in socks
                             where sockpair6 == sock6
                             select sockpair6).ToList();
            var sockPairs7 = (from sockpair7 in socks
                             where sockpair7 == sock7
                             select sockpair7).ToList();
           

            //Read each value in a foreach loop and add 1 to the counter everytime it runs
            foreach (var item in sockPairs)
            {
                count++;
                Console.WriteLine("Item 1: {0}",item);

            }
           
            foreach (var item2 in sockPairs2)
            {
                count2++;
                Console.WriteLine("Item 2: {0}",item2);

            }
            foreach (var item3 in sockPairs3)
            {
                count3++;
                Console.WriteLine("Item 3: {0}",item3);

            }
            foreach (var item4 in sockPairs4)
            {
                count4++;
                Console.WriteLine("Item 4: {0}",item4);

            }
           
            foreach (var item5 in sockPairs5)
            {
                count5++;
                Console.WriteLine("Item 5: {0}",item5);

            }
            foreach (var item6 in sockPairs6)
            {
                count6++;
                Console.WriteLine("Item 6: {0}",item6);

            }
            foreach (var item7 in sockPairs7)
            {
                count7++;
                Console.WriteLine("Item 7: {0}",item7);

            }
            //If statements will be used to show the numbers of pairs
            if(sockPairs[0] == sock)
            {
                if(count >=2)
                {
                    count -=2;
                    pairs++;
                if(count >=2)
                {
                    count -=2;
                    pairs++;
                }
                }
                
            }
            if(sockPairs2[0] == sock2)
            {
                if(count2 >=2)
                {
                    count2 -=2;
                    pairs++;
                if(count2 >=2)
                {
                    count2 -=2;
                    pairs++;
                }
                }
                
            }
            if(sockPairs3[0] == sock3)
            {
                if(count3 >=2)
                {
                    count3 -=2;
                    pairs++;
                if(count3 >=2)
                {
                    count3 -=2;
                    pairs++;
                }
                }
                
            }
            
            
            return $"There are {pairs} pairs of socks";
        } 

    }



}