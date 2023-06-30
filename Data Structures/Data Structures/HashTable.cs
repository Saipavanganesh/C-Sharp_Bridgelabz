using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class HashNode
    {
        public int Key;
        public string Value;
        public HashNode Next;

        public HashNode(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
    public class HashTable
    {
        const int TableSize = 10;
        HashNode[] table;


        public HashTable()
        {
            table = new HashNode[TableSize]; //assigning all slots of hashtable with null
        }


        public int HashFunction(int key)
        {
            int index = key % TableSize;
            //Console.WriteLine(index);
            return index;
        }


        public void Add(int key, string value)
        {
            int index = HashFunction(key);
            if (table[index] == null)      //Checking if the slot is empty
            {
                table[index] = new HashNode(key, value);
            }
            else
            {
                HashNode newNode = new HashNode(key, value);
                HashNode tempNode = table[index];
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = newNode;
            }
        }


        public string Get(int key)
        {
            int index = HashFunction(key);
            if (table[index] != null) //checking if there is any key value at the index
            {
                HashNode tempNode = table[index];
                while (tempNode != null)
                {
                    if (tempNode.Key == key)
                    {
                        return tempNode.Value;
                    }
                    tempNode = tempNode.Next;
                }
            }
            return null;
        }


    }
}
