using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class InsertionSort: MonoBehaviour
{

    [SerializeField] int[] unsortArray;
    [SerializeField] int[]  sortedArray;

    [Header("UI")]
    [SerializeField] Text resultText;


    private void Start()
    {
        sortedArray = new int[unsortArray.Length];
        for (int i = 0; i < unsortArray.Length; i++)
            sortedArray[i] = unsortArray[i];

        GetInsertionSort(sortedArray);
       // resultText.text = "(Binary Search) Key =" + key.ToString() + " / index is =" + result.ToString();
    }

    private void GetInsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int val = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > val)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = val;
        }
    }
}
