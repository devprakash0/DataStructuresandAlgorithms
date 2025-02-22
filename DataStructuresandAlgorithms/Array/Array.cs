using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms.Array
{
    public class Array
    {
        // What you need to know about arrays
        // 1. Arrays are fixed in size
        // 2. Arrays are of fixed type
        // 3. Arrays are zero-based
        // 4. Arrays are reference types
        // 5. Arrays are stored in contiguous memory locations
        // 6. Arrays are faster than lists
        // 7. Arrays are not dynamic
        // 8. Arrays are not flexible
        // 9. Arrays are not type-safe
        // 10. Arrays are not thread-safe
        // 11. Arrays are not null-safe
        // 12. Arrays are not generic
        // 13. Arrays are not resizable
        // 14. Arrays are not dynamic
        // 15. Arrays contains anything
        // 16 Killer Feature GET SET
        // Think "Hard Drive vs RAM"
        // Lists<> are actually arrays with some extra features



        // Array Insertion and Deletion Operations
        // Insert at the end of the array O(1)
        // Insert at the beginning of the array O(n)
        // Insert at any given index O(n)
        // Insert anywhere in the array O(n)
        // Delete from the end of the array O(1)
        // Delete from the beginning of the array O(n)
        // Delete from any given index O(n)
        // Delete from anywhere in the array O(n)



        // Insert at the end of the array O(1)
        public void Insert_at_the_end_of_the_array()
        {
            int[] ints = new int[5];

            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                ints[count] = i;
                count++;
            }

            // insert at the end of the array
            ints[count] = 3;
            count++;
        }

        // Insert at the beginning of the array O(n)
        public void Insert_at_the_beginning_of_the_array()
        {
            int[] ints = new int[5];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                ints[count] = i;
                count++;
            }
            // insert at the beginning of the array
            for (int i = count; i >= 1; i--)
            {
                ints[i] = ints[i - 1];
            }
            ints[0] = 3;
            count++;
        }

        // Insert at any given index O(n)
        public void Insert_at_any_given_index()
        {
            int[] ints = new int[5];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                ints[count] = i;
                count++;
            }
            // insert at any given index
            int index = 1;
            for (int i = count; i >= index; i--)
            {
                ints[i] = ints[i - 1];
            }
            ints[index] = 3;
            count++;
        }

        // Insert anywhere in the array O(n)
        public void Insert_anywhere_in_the_array()
        {
            int[] ints = new int[5];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                ints[count] = i;
                count++;
            }
            // insert anywhere in the array
            int index = 1;
            int value = 3;
            for (int i = count; i >= index; i--)
            {
                ints[i] = ints[i - 1];
            }
            ints[index] = value;
            count++;
        }
    }
}
