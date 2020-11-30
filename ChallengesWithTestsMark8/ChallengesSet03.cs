using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
                bool containsF = false;
            foreach (bool value in vals)
            {
                if (value == false)
                {
                    containsF = true;
                }           
            }
            return containsF;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach(int number in numbers)
            {
                if (number % 2 != 0)
                {
                     sum += number;
                }
                
            }
            return sum % 2 != 0; 
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string[] characters = {"abcdefghijklmnopqrstuvwxyz","0123456789","ABCDEFGHIJKLMNOPQRSTUVWXYZ"};
            int count = 0;
            foreach (var item in characters)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (password.Contains(item[i]))
                    {
                        count++;
                        break;
                    }
                    
                }               
                                
            }

            return count == 3;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            // return val[val.Length -1];
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0: dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    odds[i / 2] = i;
                }
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }          
                        
        }
    }
}
