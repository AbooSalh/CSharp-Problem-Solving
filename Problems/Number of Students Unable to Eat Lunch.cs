namespace CSPS.Problems
{
    internal class Number_of_Students_Unable_to_Eat_Lunch : IProblem

    {
        public string Result
        {
            get
            {
                int[] students = [1, 1, 1, 0, 0, 1];
                int[] sandwiches = [1, 0, 0, 0, 1, 1];
                return CountStudents(students, sandwiches).ToString();
            }
        }

        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> studentQueue = new(students);
            Stack<int> sandwichStack = new(sandwiches.Reverse());
            while (studentQueue.Count > 0 && sandwichStack.Count > 0)
            {
                if (studentQueue.Peek() == sandwichStack.Peek())
                {
                    studentQueue.Dequeue();
                    sandwichStack.Pop();
                }
                else
                {
                    studentQueue.Enqueue(studentQueue.Dequeue());
                }
                // break the loop if all students have been cycled through without any matches
                if (studentQueue.Count > 0 && studentQueue.All(s => s != sandwichStack.Peek()))
                {
                    break;
                }


            }
            return studentQueue.Count;
        }
    }
}
