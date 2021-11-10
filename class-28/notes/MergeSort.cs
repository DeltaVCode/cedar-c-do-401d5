arr = [2, 6, 4, 3, 1]
mid   ------^

mid = 5/2 = 2;
left = [2, 6]
right = [4, 3, 1]


int mid = arr.Length / 2;

int[] left = new int[mid]; // 2
int[] right = new int[arr.Length - mid]; // 3

for (int i = 0; i < left.Length; i++)
  left[i] = arr[i];

for (int j = 0; j < right.Length; j++)
  right[j] = arr[mid + j];

// Array.Copy()



// New C# range operator
int[] left = arr[0..mid];
int[] right = arr[mid..]; // mid to end
