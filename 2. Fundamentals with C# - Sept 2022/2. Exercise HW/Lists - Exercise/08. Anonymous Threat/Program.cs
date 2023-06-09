using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    FixInvalidIndexes(words, ref startIndex, ref endIndex);
                    MergeWords(words, startIndex, endIndex);
                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);

                    //abcde -> ab, bc, e (Wrong, we want the last one to be the longest)
                    //abcde -> a, b, cde 5 : 3 = 1
                    //abcdef -> ab, cd, ef
                    string word = words[index];
                    List<string> partitionsList = DivideWord(word, partitions);

                    words.RemoveAt(index);
                    words.InsertRange(index, partitionsList);
                }
            }

            Console.WriteLine(String.Join(" ", words));
        }

        static void FixInvalidIndexes(List<string> words, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                //First possible
                startIndex = 0;
            }

            if (startIndex >= words.Count)
            {
                startIndex = words.Count - 1;
            }

            if (endIndex <= 0)
            {
                endIndex = 0;
            }

            if (endIndex >= words.Count)
            {
                //Last possible
                endIndex = words.Count - 1;
            }
        }

        static void MergeWords(List<string> words, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = words[startIndex];
                mergedText += currWord;
                words.RemoveAt(startIndex);
            }

            words.Insert(startIndex, mergedText);
        }

        static List<string> DivideWord(string word, int partitions)
        {
            int substringsLength = word.Length / partitions;
            int lastSubstringLength = substringsLength + word.Length % partitions;
            //int lastSubstringLength = word.Length - ((partitions - 1) * substringsLength);

            List<string> partitionsList = new List<string>();
            //All without the last one
            for (int i = 0; i < partitions; i++)
            {
                int desiredLength = substringsLength;
                if (i == partitions - 1)
                {
                    desiredLength = lastSubstringLength;
                }

                char[] newPartitionArr = word
                    .Skip(i * substringsLength)
                    .Take(desiredLength)
                    .ToArray();
                string newPartition = String.Join("", newPartitionArr);
                partitionsList.Add(newPartition);
            }

            return partitionsList;

            //OTHER WAY

            //List<string> data = Console.ReadLine()
            //                           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //                           .ToList();
            //
            //string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //while (command[0] != "3:1")
            //{
            //    switch (command[0])
            //    {
            //        case "merge":
            //            int start = int.Parse(command[1]);
            //            int end = int.Parse(command[2]);
            //            string merged = string.Empty;
            //
            //            if (start < 0 || start >= data.Count)
            //            {
            //                start = 0;
            //            }
            //
            //            if (end >= data.Count || end < 0)
            //            {
            //                end = data.Count - 1;
            //            }
            //
            //            for (int i = start; i <= end; i++)
            //            {
            //                merged += data[start];
            //                data.RemoveAt(start);
            //            }
            //
            //            data.Insert(start, merged);
            //            break;
            //
            //        case "divide":
            //            int index = int.Parse(command[1]);
            //            int partitions = int.Parse(command[2]);
            //            string element = data[index];
            //            data.RemoveAt(index);   // Remove the element, later insert the divided elements at this index 1 by 1 starting with the longest
            //
            //            int iterator = element.Length / partitions;
            //            for (int i = element.Length - 1; i >= 0; i -= iterator) // Start iterating BACKWARDS, so we can firstly add the longest element
            //            {                                                       // The iterator step is equal to the short element's count (a, b, cd)
            //                if (element.Length % partitions == 0)               //                                                    (1)    1  1  2
            //                {
            //                    data.Insert(index, element.Substring(i - iterator + 1, iterator));
            //                }
            //                else
            //                {
            //                    if (i == element.Length - 1)    // On the LAST INDEX, ADD LONGEST ELEMENT, then MOVE index backwards after that element
            //                    {
            //                        int longestElementCount = (element.Length % partitions) + element.Length / partitions;
            //                        data.Insert(index, element.Substring(element.Length - longestElementCount, longestElementCount));
            //                        i = element.Length - longestElementCount;   // MOVE the index of the loop back, LONGEST ELEMENT ADDED
            //                    }
            //                    else
            //                    {
            //                        data.Insert(index, element.Substring(i, iterator)); // ADD SHORT ELEMENTS
            //                    }
            //                }
            //            }
            //
            //            break;
            //    }
            //
            //    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //}
            //
            //Console.WriteLine(String.Join(" ", data));
        }
    }
}
