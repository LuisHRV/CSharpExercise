using System;

namespace ExercicioTypeSafety.Entities
{
    class PrintServises<T>
    {


        private T[] _values = new T[10];
        private int _count = 0;

        public PrintServises()
        {
        }

        public void AddValues(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintServices is Full");
            }
            _values[_count] = value;
            _count++;
        }
        public T First()
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintServices is empty");
            }
            return _values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
