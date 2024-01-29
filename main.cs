using System;

class Program {
  public static void Main (string[] args) {

    int[] unsortedArray = {5, 12, 8, 3, 17, 9, 14, 6, 1, 19, 11, 7, 15, 2, 10, 16, 4, 20, 13, 18};

    selectionsort(unsortedArray);

    for (int i = 0; i < unsortedArray.Length; i++){
      Console.WriteLine(unsortedArray[i]);
    }
    
  }

  public static void selectionsort(int[] array){
    int temp = 0;
    int min = 0;

    for (int i = 0; i < array.Length; i++){
      min = i;

      for (int j = i + 1; j < array.Length; j++){
        if (array[j] < array[min]){
          min = j;
        }
      }

      temp = array[i];
      array[i] = array[min];
      array[min] = temp;
      
    }
  }
  
}