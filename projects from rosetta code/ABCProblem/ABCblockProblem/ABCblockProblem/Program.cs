using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCblockProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Blocks> seedBlocks = AllBlocks("BOXKDQCPNAGTRETGQDFSJWHUVIANOBERFSLYPCZM");

            Console.WriteLine("enter a word");
            string testWord = Console.ReadLine().ToUpper();
            List<string> testListWord = WordIntoList(testWord);
            HashSet<Blocks> uniqueBlocks = AvailableBlocks(testListWord, seedBlocks);

            //bool answer = wordFromBlocks(testWord);

            foreach (Blocks b in uniqueBlocks)
            {
                Console.WriteLine($"{b.blockNumber} - {b.sideOne} {b.sideTwo}");
            }
                


            List<Blocks> AllBlocks(string twos)
            {
                List<Blocks> blockSet = new List<Blocks>();
                string sub;
                int iD = 1;

                do
                {
                    sub = twos.Substring(0, 2);
                    twos = twos.Remove(0, 2);

                    blockSet.Add(new Blocks(sub[0], sub[1], iD));
                    iD++;
                } while (twos.Length > 1);
                return blockSet;
            }

            List<string> WordIntoList(string word)
            {
                List<string> wordSeparator = new List<string>();

                for (int i = 0; i < word.Length; i++)
                {
                    wordSeparator.Add(word[i].ToString());
                }

                return wordSeparator;
            }

            HashSet<Blocks> AvailableBlocks(List<string> wordIntoList, List<Blocks> allBlocks)
            {
                HashSet<Blocks> fillBlockPool = new HashSet<Blocks>();
                for(int j = 0; j < wordIntoList.Count; j++)
                {
                    for (int i = 0; i < allBlocks.Count; i++)
                    {
                        if (allBlocks[i].sideOne == wordIntoList[j])
                        {
                            fillBlockPool.Add(allBlocks[i]);
                        }
                    }
                    for (int i = 0; i < allBlocks.Count; i++)
                    {
                        if (allBlocks[i].sideTwo == wordIntoList[j])
                        {
                            fillBlockPool.Add(allBlocks[i]);
                        }
                    }
                }
                return fillBlockPool;
            }



        }
    }
}
