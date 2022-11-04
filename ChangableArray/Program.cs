int[] arr = { 2, 3, 4, 1, 5, 6}; // ---> 1 2 3 6 5 4 
for (int i = 0; i < arr.Length; i++)
{
	for (int j = i+1; j < arr.Length; j++)
	{
		if (arr[j] < arr[i])
		{
			int temp = arr[j];
			arr[j] = arr[i];
			arr[i] = temp;
		}
	}
}
int mid = (arr[arr.Length-1] + arr[0])/2;
Console.WriteLine(mid);
for (int i = mid; i < arr.Length; i++)
{
		for (int j = i; j < arr.Length; j++)
		{
            if (arr[j] > arr[i])
            {
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
        }
	}
for (int i = 0; i < arr.Length; i++)
{
	Console.Write(arr[i] + " ");
}