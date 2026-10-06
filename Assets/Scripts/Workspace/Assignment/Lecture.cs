using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedlist = new LinkedList<string>();

            linkedlist.AddLast("Node 1");

            linkedlist.AddLast("Node 2");

            linkedlist.AddFirst("Node 0");

            LinkedListNode<string> firstNode = linkedlist.First;
            Debug.Log("last: " + firstNode.Value);

            LinkedListNode<string> lastNode = linkedlist.First;
            Debug.Log("last: " + lastNode.Value);

            Debug.Log("firstNode.Next: " + firstNode.Next.Value);
            Debug.Log("firstNode.Next.Next: " + firstNode.Next.Next.Value);

            Debug.Log("lastNode.Previous: " + lastNode.Previous.Value);
            Debug.Log("lastNode.Previous: " + lastNode.Previous.Previous.Value);

            if (firstNode.Previous == null) Debug.Log("firstNode.Previous == null");
            if (lastNode.Next == null) Debug.Log("lastNode.Next == null");

            linkedlist.AddAfter(firstNode, "Node 0.5");

            linkedlist.AddBefore(lastNode, "Node 1.5");

            LinkedListNode<string> node1 = linkedlist.Find("Node 1");

            linkedlist.Remove("Node 1");
            linkedlist.Remove(node1);
            linkedlist.RemoveLast();
            linkedlist.RemoveFirst();

            linkedlist.Clear();
        }

        public void LCT03_SyntaxHashTable()
        {
            Hashtable table = new Hashtable();
            table.Add("Potion", 1);
            table.Add(true, "");
            table.Add(0, 0);
            table[true] = 1;
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();
            var inv2 = new Dictionary<string, int>();

            // "Potion": 1
            inv.Add("Potion", 1);

            // "Potion": 1
            // "Apple": 10
            inv.Add("Apple", 10);

            // "Potion": 1
            // "Apple": 10
            // "Banana": 5
            inv["Banana"] = 5;

            // "Potion": 10
            // "Apple": 10
            // "Banana": 5
            inv["Potion"] = 10;

            var pickupItem = "Sword";
            // "Potion": 10
            // "Apple": 10
            // "Banana": 5
            // "Sword": 5
            inv[pickupItem] = 1;

            //foreach (KeyValuePair<string, int> pair in inv)
            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }

            var appleExists = inv.ContainsKey("Apple");
            Debug.Log(appleExists);

            var keyExists = inv.ContainsKey("Key");
            Debug.Log(keyExists);

            inv.Remove("Apple");

            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }
        }

        #endregion
    }
}