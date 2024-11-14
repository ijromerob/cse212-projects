using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items: A(2),B(5),C(3) and run until it is empty
    // Expected Result: B,C,A
    // Defect(s) Found: There was not count of the lists that would aid the process of ending the loop, the for loop was starting at 1 and needed to start at 0, it wasn't removing the item with highest priority - PASSED
    public void TestPriorityQueue_1()
    {

        var A = new PriorityItem("A",2);
        var B = new PriorityItem("B",5);
        var C = new PriorityItem("C",3);

        PriorityItem[] expectedResult = [B,C,A];

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(A.Value,A.Priority);
        priorityQueue.Enqueue(B.Value,B.Priority);
        priorityQueue.Enqueue(C.Value,C.Priority);

        int i = 0;
        while (0 < priorityQueue.Count)
        {
          if (expectedResult.Length <= i)
          {
            Assert.Fail("Queue should have finished");
          }
          var item = priorityQueue.Dequeue();
          Assert.AreEqual(expectedResult[i].Value, item);
          i++;
        }
    }

    [TestMethod]
    // Scenario: Create a queue with the following items: A(2),B(5),C(5), D(3) and run until it is empty
    // Expected Result:B,C,D,A
    // Defect(s) Found: the index assignment was not working properly since the condition was changing the index whenever there was another element with a highest priority - PASSED
    public void TestPriorityQueue_2()
    {
        var A = new PriorityItem("A",2);
        var B = new PriorityItem("B",5);
        var C = new PriorityItem("C",5);
        var D = new PriorityItem("D",3);

        PriorityItem[] expectedResult = [B,C,D,A];

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(A.Value,A.Priority);
        priorityQueue.Enqueue(B.Value,B.Priority);
        priorityQueue.Enqueue(C.Value,C.Priority);
        priorityQueue.Enqueue(D.Value,D.Priority);

        int i = 0;
        while (0 < priorityQueue.Count)
        {
          if (expectedResult.Length <= i)
          {
            Assert.Fail("Queue should have finished");
          }
          var item = priorityQueue.Dequeue();
          Assert.AreEqual(expectedResult[i].Value, item);
          i++;
        }
    }

    // Add more test cases as needed below.
}