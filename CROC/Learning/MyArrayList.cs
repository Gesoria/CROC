namespace CROC.Learning
{
    public class MyArrayList : object
    {
        private int _capacity;
        private int[] _array;

        public MyArrayList(MyArrayList arrayToCopy)
        {
            _capacity = arrayToCopy._capacity;
            _array = new int[arrayToCopy._array.Length];
            arrayToCopy._array.CopyTo(_array, 0);

        }

        public MyArrayList(int capacity)
        {
            _capacity = capacity;
        }

        public MyArrayList()
        {
            _capacity = 0; //область видимости листа
            _array = new int[10];//кол-во элементов в созданном массиве

        }
        public void Add(int value)
        {
            _array[_capacity] = value;
            _capacity++;

            if (_capacity == _array.Length)
            {
                int[] newArray = new int[_array.Length * 2];

                //for (int i = 0; i < _array.Length; i++)
                //{
                //    newArray[i] = _array[i];
                //}

                _array.CopyTo(newArray, 0);

                _array = newArray;
            }
        }
        public override string ToString()
        {
            string s = string.Empty;
            int counter = 0;
            while (counter < _capacity)
            {
                s += _array[counter] + " ";
                counter++;
            }
            return s;
        }
        public void DeleteByIndex(int index)
        {
            while (index < _capacity)
            {
                _array[index] = _array[index + 1];
                index++;

            }
            _capacity--;
        }
        public int GetByIndex(int index)
        {

            return _array[index];
        }
        public object GetIndexByValue(int value)
        {
            string fuckup = "такого числа нет";
            int index = 0;
            while (index < _capacity)
            {

                if (value == _array[index])
                {

                    return index;

                }

                index++;

            }
            return fuckup;
        }
        public void Reverse()
        {

            int endindex = _capacity - 1;
            int temp = 0;

            for (int i = 0; i < endindex; i++, endindex--)
            {
                temp = _array[i];
                _array[i] = _array[endindex];
                _array[endindex] = temp;

            }
            Console.WriteLine();


        }
        public void RemoveRange(int index, int range)
        {
            int newlastindex = _capacity - 1 - range;

            for (; index != newlastindex; index++)
            {
                _array[index] = _array[index + range];

            }
            _capacity = newlastindex + 1;
        }
        public void InsertByIndex(int index, int value)
        {
            int lastindex = _capacity;
            _capacity++;

            for (; index <= lastindex; lastindex--)
            {
                _array[lastindex] = _array[lastindex - 1];

                if (index == lastindex)
                {
                    _array[index] = value;

                }

            }

        }
        public int Sum()
        {
            int sum = 0;

            for (int i = 0; i < _capacity; i++)
            {
                sum += _array[i];
            }

            return sum;
        }

        public int MaxValue()
        {
            int max = _array[0];

            for (int i = 1; i < _capacity; i++)
            {

                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }
        public int MinValue()
        {
            int min = _array[0];
            for (int i = 1; i < _capacity; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }

            }
            return min;
        }


    }


}
