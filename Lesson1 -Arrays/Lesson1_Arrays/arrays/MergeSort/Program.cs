using System;
using System.Collections;

namespace MergeSort 
{
    class MergeSort 
    {
        static void Main ()
        {
            MergeSorter oSorter = new MergeSorter();
            ArrayList arrayUnsorted= new ArrayList();
            Console.WriteLine("How many numbers will you be sorting?");
            Console.Write("Number count: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Number[{0}] = ", i + 1);
                arrayUnsorted.Add(int.Parse(Console.ReadLine()));
            }

            ArrayList arraySorted = oSorter.MergeSort(arrayUnsorted);
          
            foreach (int i in arraySorted)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
        }
    }
}
class MergeSorter {
  
    public MergeSorter()
    {
    }
    public ArrayList MergeSort ( ArrayList arrIntegers ) 
    {
        if (arrIntegers.Count == 1) 
        {
            return arrIntegers;
        }
        ArrayList arrSortedInt = new ArrayList();
        int middle = (int)arrIntegers.Count/2;

        ArrayList leftArray = arrIntegers.GetRange(0, middle);
        ArrayList rightArray = arrIntegers.GetRange(middle, arrIntegers.Count - middle);

        leftArray =  MergeSort(leftArray);
        rightArray = MergeSort(rightArray);

        int leftptr = 0;
        int rightptr=0;
       
        for (int i = 0; i < leftArray.Count + rightArray.Count; i++) 
        {
            if (leftptr==leftArray.Count)
            {
                arrSortedInt.Add(rightArray[rightptr]);
                rightptr++;
            }
            else if (rightptr==rightArray.Count)
            {
                arrSortedInt.Add(leftArray[leftptr]);
                leftptr++;
            }
            else if ((int)leftArray[leftptr]<(int)rightArray[rightptr])
            {
                //need the cast above since arraylist returns Type object
                arrSortedInt.Add(leftArray[leftptr]);
                leftptr++;
            }
            else
            {
                arrSortedInt.Add(rightArray[rightptr]);
                rightptr++;
            }
        }
        return arrSortedInt;
    }
}
