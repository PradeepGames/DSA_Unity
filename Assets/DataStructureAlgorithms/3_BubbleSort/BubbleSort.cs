using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class BubbleSort : MonoBehaviour
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

        GetBubbleSort(sortedArray);
       // resultText.text = "(Binary Search) Key =" + key.ToString() + " / index is =" + result.ToString();
    }

    private void GetBubbleSort(int[] arr)
    {
        int couter = 1;

        while (couter < arr.Length)
        {
            for (int i = 0; i < arr.Length - couter; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            couter++;
        }
    }
}
