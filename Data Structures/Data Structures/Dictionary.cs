using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class DictNode
    {
        public int Key;
        public string Value;
        public DictNode Next;

        public DictNode(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
    public class Dictionary
    {
        const int DictSize = 10;
        DictNode[] dictTable; //Creating empty dictionary array as DictNode type


        public Dictionary()
        {
            dictTable = new DictNode[DictSize];
        }


        public int GetDictIndex(int key)
        {
            return key % DictSize;
        }


        public void Add(int key, string value)
        {
            int index = GetDictIndex(key);
            DictNode newNode = new DictNode(key, value);

            if (dictTable[index] == null)
            {
                dictTable[index] = newNode;
            }
            else
            {
                DictNode tempNode = dictTable[index]; //Traversing to end and placing the node 
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = newNode;
            }
        }

        public string Get(int key)
        {
            int index = GetDictIndex(key);
            DictNode newNode = dictTable[index];

            while (newNode != null)
            {
                if (newNode.Key == key)
                {
                    return newNode.Value;
                }
                newNode = newNode.Next;
            }
            return null;
        }
        public void Display()
        {
            for (int i = 0; i < DictSize; i++)
            {
                Console.Write($"({i}): ");
                DictNode tempNode = dictTable[i];
                while (tempNode != null)
                {
                    Console.Write($"{tempNode.Key}:{tempNode.Value}, ");
                    tempNode = tempNode.Next;
                }
                Console.WriteLine();
            }
        }
    }


}
