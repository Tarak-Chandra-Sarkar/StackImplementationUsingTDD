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
            stackArray[Size++] = val;
        }

        public T Pop()
        {
            return stackArray[--Size];
        }
        #endregion
    }
}
