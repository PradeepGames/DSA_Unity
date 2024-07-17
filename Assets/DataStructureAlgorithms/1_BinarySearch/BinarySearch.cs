using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BinarySearch : MonoBehaviour
{

    [SerializeField] int[] array = new int[10] { 45, 34, 54, 37, 94, 12, 35, 54, 37, 94 };
    [SerializeField] int key = 12;

    [Header("UI")]
    [SerializeField] Text resultText;


    private void Start()
    {
        int result = GetBanarySearch(array, key);
        resultText.text = "(Binary Search) Key =" + key.ToString() + " / index is =" + result.ToString();
    }

    private int GetBanarySearch(int[] arr, int key)
    {
        int s = 0;
        int end = array.Length;

        while (s <= end)
        {
            int mid = (s + end) / 2;
            if (arr[mid] == key)
            {
                return mid;
            }else if (arr[mid] > key)
            {
                end = mid - 1;
            }else
            {
                s = mid + 1;
            }
        }

        return -1;
    }
}
