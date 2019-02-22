namespace StackImplementationUsingTDD
{
    public class StackImplementation<T>
    {
        #region Members
        private T[] stackArray;
        private int maxLength;
        #endregion

        #region Properties
        public int Size { get; private set; }
        #endregion

        #region Constructor
        public StackImplementation(int length)
        {
            maxLength = length;
            stackArray = new T[length];
        }
        #endregion

        #region Public Methods
        public void Push(T val)
        {
            if (Size == maxLength)
            {
                throw new ExceededSizeException();
            }

            stackArray[Size++] = val;
        }

        public T Pop()
        {
            if (Size == 0)
            {
                throw new ExpenditureProhibitedException();
            }

            return stackArray[--Size];
        }
        #endregion
    }
}
