using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LeetCode
{
    public class LeetCodeLib : ILeetCodeLib
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
                }
            }
            throw new Exception();
        }
        
        public int[] RunningSum(int[] nums)
        {
            List<int> result = new List<int>();
            var temp = 0;
            nums.ToList().ForEach(x =>
            {
                temp = temp + x;
                result.Add(temp);
            });
            return result.ToArray();
        }
                
        public int[] Shuffle(int[] nums, int n)
        {
            List<int> result = new List<int>();
            for(int i=0;i<2*n;i++)
            {
                if (i % 2 == 0)
                    result.Add(nums[i/2]);
                else
                    result.Add(nums[n+i/2]);
            }
            return result.ToArray();
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var input = candies.ToList();
            List<bool> result = new List<bool>();
            var greatest = input.Max();
            input.ForEach(x => result.Add(x + extraCandies >= greatest));
            return result;
        }

        public int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for(int i=0;i<nums.Length - 1;i++)
                for(int j=i+1;j< nums.Length;j++)
                {
                    if (nums[i] == nums[j])
                        count++;
                }
            return count;
        }

        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }

        public int NumJewelsInStones(string J, string S)
        {
            var cond = J.ToCharArray().Distinct();
            return S.ToCharArray().Count(x => cond.Contains(x));
        }

        public int NumberOfSteps(int num)
        {
            int count = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num -= 1;
                count++;
            }
            return count;
        }

        public string RestoreString(string s, int[] indices)
        {
            List<(int, char)> data = new List<(int, char)>();
            for (int i = 0; i < indices.Length; i++)
            {
                (int, char) t = (indices[i], s[i]);
                data.Add(t);
            }
            return new string(data.OrderBy(x => x.Item1).Select(x => x.Item2).ToArray());
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var input = nums.ToList();
            var output = new List<int>();
            input.ForEach(x=>output.Add(input.Count(y=> y<x)));
            return output.ToArray();
        }

        public int XorOperation(int n, int start)
        {
            var output = 0x0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    output = start;
                else
                    output = output ^ (start + 2 * i);
            }
            return output;
        }

        public int SubtractProductAndSum(int n)
        {
            var product = 1;
            var sum = 0;
            while (n>=10)
            {
                var temp = n % 10;
                product *= temp;
                sum += temp;
                n = n / 10;
            }
            product *= n;
            sum += n;
            return product - sum;
        }

        public int[] DecompressRLElist(int[] nums)
        {
            var output = new List<int>();
            for(int i=0;i<nums.Length;i+=2)
            {
                for (int j = 0; j < nums[i]; j++)
                    output.Add(nums[i + 1]);
            }
            return output.ToArray();
        }

        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var output = new List<int>();
            for(int i = 0;i<nums.Length;i++)
            {
                var temp = output.Take(index[i]).ToList();
                temp.Add(nums[i]);
                temp.AddRange(output.Skip(index[i]));
                output = temp;
            }
            return output.ToArray();
        }
        // 類遞增
        public bool CheckPossibility(int[] nums)
        {
            bool modify = false;
            bool result = true;
            var temp = nums.ToArray();
            for (int i =1;i< temp.Length;i++)
            {
                if (temp[i - 1] > temp[i])
                {
                    if (modify)
                    {                        
                        result = false;
                        break;
                    }
                    modify = true;
                    temp[i] = temp[i - 1];
                }
            }
            if (result)
                return true;
            modify = false;
            result = true;
            temp = nums.ToArray();
            for (int i = temp.Length - 1; i >0; i--)
            {
                if (temp[i - 1] > temp[i])
                {
                    if (modify)
                    {
                        return false;
                    }
                    modify = true;
                    temp[i - 1] = temp[i];
                }
            }
            return result;
        }
        public class Group
        {
            //public int Id { get; set; }
            public int limit { get; set; }
            public List<People> peoples { get; set; }
        }

        public class People
        {
            public int Id { get; set; }
            public int limit { get; set; }

        }
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            List<Group> groups = new List<Group>();
            List<People> peoples = new List<People>();
            IList<IList<int>> result = new List<IList<int>>();
            int currId = 0;
            groupSizes.ToList().ForEach(x => {
                groups.Add(new Group { limit = x, peoples =new List<People>()});
                peoples.Add(new People { Id = currId, limit = x });
                currId++;
            });
            peoples.ForEach(x => {
                var target = groups.Where(y => y.limit == x.limit && y.peoples.Count() < y.limit).FirstOrDefault();
                target.peoples.Add(x);
            });
            groups.Where(x => x.peoples.Count > 0).ToList().ForEach(x => {
                result.Add(x.peoples.Select(y => y.Id).ToList());
            });
            return result;
        }
        public enum RoomState 
        { 
            IsDelete = -1,
            OK = 0,
            Start = 1,
            End = 2
        }
        public class Room
        {
            public int Id { get; set; }
            // 位置
            public int PosX { get; set; }
            public int PosY { get; set; }
           
            // 出口
            public Room EastRoom { get; set; }
            public Room SouthRoom { get; set; }
            public Room WestRoom { get; set; }
            public Room NorthRoom { get; set; }
            // 狀態
            public RoomState RoomState { get; set; }
            public RoomState UsedState { get; set; }
            public Room(int id, int posX, int posY, RoomState roomState)
            {
                Id = id;
                PosX = posX;
                PosY = posY;
                RoomState = roomState;
            }
        }
        public int UniquePathsIII(int[][] grid)
        {
            var currId = 0;
            var rooms = new List<Room>();
            // map create
            for(int y=0;y< grid.Length;y++)
            {
                for(int x=0; x< grid[y].Length;x++)
                {
                    currId++;
                    var newRoom = new Room(currId, x, y, (RoomState)grid[y][x]);
                    //上邊界
                    if (y > 0)
                    {
                        newRoom.NorthRoom = rooms.Where(room => room.PosX == x && room.PosY == y - 1).FirstOrDefault();
                        newRoom.NorthRoom.SouthRoom = newRoom;
                    }                        
                    if(x>0)
                    {
                        newRoom.WestRoom = rooms.Where(room => room.PosX == x - 1 && room.PosY == y).FirstOrDefault();
                        newRoom.WestRoom.EastRoom = newRoom;
                    }
                        
                    //if(y< grid.Length-1)
                    //{
                    //    newRoom.SouthRoom = rooms.Where(room => room.PosX == x && room.PosY == y + 1).FirstOrDefault();
                    //    newRoom.SouthRoom.NorthRoom = newRoom;
                    //}
                        
                    //if(x< grid[y].Length)
                    //{
                    //    newRoom.EastRoom = rooms.Where(room => room.PosX == x + 1 && room.PosY == y).FirstOrDefault();
                    //    newRoom.EastRoom.WestRoom = newRoom;
                    //}
                        
                    rooms.Add(newRoom);
                }
            }
            // path
            var currRoom = rooms.FirstOrDefault(r => r.RoomState == RoomState.Start);
            
            // 須走到指定步數
            var stepNumberMax = currId - rooms.Count(r => r.RoomState == RoomState.IsDelete) - 1;

            int successNumber = 0;
            currRoom.UsedState = RoomState.Start;

            var target = currRoom.EastRoom;           

            if (IsSafe(target, stepNumberMax))
                FindPath(rooms, target, stepNumberMax, ref successNumber);
            rooms.Where(x=>x.Id!= currRoom.Id).ToList().ForEach(r => r.UsedState = RoomState.OK);

            target = currRoom.SouthRoom;
            if (IsSafe(target, stepNumberMax))
                FindPath(rooms, target, stepNumberMax, ref successNumber);
            rooms.Where(x => x.Id != currRoom.Id).ToList().ForEach(r => r.UsedState = RoomState.OK);

            target = currRoom.WestRoom;
            if (IsSafe(target, stepNumberMax))
                FindPath(rooms, target, stepNumberMax, ref successNumber);
            rooms.Where(x => x.Id != currRoom.Id).ToList().ForEach(r => r.UsedState = RoomState.OK);

            target = currRoom.NorthRoom;
            if (IsSafe(target, stepNumberMax))
                FindPath(rooms, target, stepNumberMax, ref successNumber);
            //rooms.Where(x => x.Id != currRoom.Id).ToList().ForEach(r => r.UsedState = RoomState.OK);            

            return successNumber;
        }

        public bool FindPath(List<Room> rooms, Room room,int stepNumberMax,ref int successNumber)
        {
            var isSucess = false;
            room.UsedState = RoomState.Start;
            stepNumberMax--;
            // 已找到路徑
            if (room.RoomState == RoomState.End && stepNumberMax == 0)
            {
                isSucess = true;
                room.UsedState = RoomState.OK;
                successNumber++;
                return true;
            }
            // 走到出口但沒走完全部地圖 or 步數用盡
            if (room.RoomState == RoomState.End || stepNumberMax == 0)
            {
                isSucess = false;
                room.UsedState = RoomState.OK;
                return false;
            }

            // 查找路線

            // 嘗試東出口
            var target = room.EastRoom;
            // 檢查出口狀況
            if (IsSafe(target, stepNumberMax))
            {
                // 走過去
                var result = FindPath(rooms, target, stepNumberMax, ref successNumber);                    
            }

            target = room.SouthRoom;
            if (IsSafe(target, stepNumberMax))
            {
                // 走過去
                var result = FindPath(rooms, target, stepNumberMax, ref successNumber);
            }

            target = room.WestRoom;
            if (IsSafe(target, stepNumberMax))
            {
                // 走過去
                var result = FindPath(rooms, target, stepNumberMax, ref successNumber);
            }

            target = room.NorthRoom;
            if (IsSafe(target, stepNumberMax))
            {
                // 走過去
                var result = FindPath(rooms, target, stepNumberMax, ref successNumber);
            }
            //嘗試走完之後回到上一步復原
            room.UsedState = RoomState.OK;
            stepNumberMax++;
            return successNumber>0;
        }
        public static bool IsSafe(Room room, int stepNumberMax)
        {
            if (room != null && room.RoomState != RoomState.IsDelete && room.UsedState == RoomState.OK)
                if (room.RoomState == RoomState.End && stepNumberMax != 1)
                    return false;
                else return true;

            return false;
        }
    }
}
