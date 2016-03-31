using NUnit.Framework;

namespace Task3.Tests {
    [TestFixture]
    public class CustomQueueTests {
        private CustomQueue<int> q = new CustomQueue<int>();

        public void EnqueueElements(CustomQueue<int> q, int size) {
            for(int i =  1;  i <= size; i++)
                q.Enqueue(i);
        } 
        [Test]
        [TestCase(10)]
        [TestCase(20)]
        public void DequeueTest(int size) {
            EnqueueElements(q, size);
            for(int i = 1; i <= size; i++)
                Assert.AreEqual(i, q.Dequeue());
        }
        [Test]
        public void PeekTest(){
            EnqueueElements(q, 10);
            Assert.AreEqual(1,q.Peek());
        }
        [Test]
        public void ForeachTest(){
            EnqueueElements(q, 20);
            int i = 1;
            foreach (int val in q)
                Assert.AreEqual(val,i++);
        }
    }
}
