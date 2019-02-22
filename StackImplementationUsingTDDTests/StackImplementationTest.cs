using NUnit.Framework;
using StackImplementationUsingTDD;

namespace StackImplementationUsingTDDTests
{
    [TestFixture]
    public class StackImplementationTest
    {
        [Test]
        public void Creation()
        {
            StackImplementation<int> stack = new StackImplementation<int>(3);

            Assert.AreEqual(0, stack.Size);
        }

        [Test]
        public void Push()
        {
            StackImplementation<int> stack = new StackImplementation<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.AreEqual(3, stack.Size);
        }

        [Test]
        public void Pop()
        {
            StackImplementation<int> stack = new StackImplementation<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int val = stack.Pop();

            Assert.AreEqual(3, val);
            Assert.AreEqual(2, stack.Size);
        }

        [Test]
        public void Exception_On_Too_Much_Push()
        {
            StackImplementation<int> stack = new StackImplementation<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Throws<ExceededSizeException>(() => stack.Push(4));
        }

        [Test]
        public void Exception_On_Too_Much_Pop()
        {
            StackImplementation<int> stack = new StackImplementation<int>(3);

            Assert.Throws<ExpenditureProhibitedException>(() => stack.Pop());
        }
    }
}
