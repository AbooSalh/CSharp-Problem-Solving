namespace CSPS.Searching
{
    internal class SearchingAlgos(List<int> elements)
    {
        List<int> Elements { get; set; } = elements;

        /// <summary>
        ///     uses linear search to find the index of the first occurrence of x in the list of elements. If x is not found, it returns -1.
        ///     useful when the list is unsorted or when the list is small, as it has a time complexity of O(n) in the worst case.
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="x"></param>
        /// <returns>  </returns>
        public int Linear(int x)
        {
            int length = Elements.Count;
            for (int i = 0; i < length; i++)
            {
                if (Elements[i] == x)
                    return i;
            }
            return -1;
        }

        public int Binary(int x)
        {
            int left = 0;
            int right = Elements.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (Elements[mid] == x)
                    return mid;
                else if (Elements[mid] < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
        public int Interpolation(int length, int x)
        {
            int left = 0;
            int right = Elements.Count - 1;
            while (left <= right && x >= Elements[left] && x <= Elements[right])
            {
                if (left == right)
                {
                    if (Elements[left] == x)
                        return left;
                    return -1;
                }
                int pos = left + ((right - left) / (Elements[right] - Elements[left]) * (x - Elements[left]));
                if (Elements[pos] == x)
                    return pos;
                else if (Elements[pos] < x)
                    left = pos + 1;
                else
                    right = pos - 1;
            }
            return -1;
        }
    }
}
