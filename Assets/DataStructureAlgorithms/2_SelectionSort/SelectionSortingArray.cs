using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SelectionSortingArray : MonoBehaviour
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

        GetSelectionSort(sortedArray);
       // resultText.text = "(Binary Search) Key =" + key.ToString() + " / index is =" + result.ToString();
    }

    private void GetSelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[j] < arr[i])
                {
                    int temp = arr[j];
                    Debug.Log(temp);
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}
