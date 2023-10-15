// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arr = {12, 25, 48, 52, 67, 79, 88, 93};
int key = 52;

int keyPosition = TernarySearch.IterativeApproach(0,arr.Length-1,key,arr);

if(keyPosition != -1)
    Console.WriteLine($"Index/Postion of element {key} in array = {keyPosition}");
else
    Console.WriteLine($"Element {key} is not present in the array");

Console.WriteLine("*********************************************");

int keyPositionWithRecursive = TernarySearch.RecursiveApproach(0,arr.Length-1, key, arr);

if(keyPositionWithRecursive != -1)
    Console.WriteLine($"Index/Postion of element {key} in array = {keyPositionWithRecursive}");
else
    Console.WriteLine($"Element {key} is not present in the array");



public class TernarySearch{
    public static int IterativeApproach(int low, int high, int key, int[] arr){
        while(low <= high){
        int mid_1 = low + (high-low)/3;
        int mid_2 = high - (high -low)/3;

        if(arr[mid_1] == key)
            return mid_1;
        if(arr[mid_2] == key)
            return mid_2;
        if(key < arr[mid_1])
            high = mid_1-1;
        if(key > arr[mid_2])
            low = mid_2+1;
        else{
            low = mid_1 +1;
            high = mid_2 -1;
        }
        }
        return -1;
    }

    public static int RecursiveApproach(int low, int high, int key, int[] arr){
        if(low <= high){
            int mid_1 = low + (high -low)/3;
            int mid_2 = high - (high - low)/3;

            if(arr[mid_1] == key)
                return mid_1;
            if(arr[mid_2] == key)
                return mid_2;
            if(key < arr[mid_1])
                return RecursiveApproach(low, mid_1-1, key, arr);
            if(key > arr[mid_2])
                return RecursiveApproach(mid_2+1, high, key, arr);
            else
                return RecursiveApproach(mid_1+1, mid_2-1, key, arr);
        }
        return -1;
    }
}