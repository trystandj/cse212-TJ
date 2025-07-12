using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue then add three items with different priorities. Then dequeue them one by one.
    // The items should be dequeued in the order of their priority, with the highest priority item being dequeued first.
    // Expected Result: The items should be added to the queue in the order of their priority 
    // Defect(s) Found: The dequeue meathod is not removing any item and the condition of the for loop is not correct. It needs to be index <= _queue.Count - 1;
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 2);
        priorityQueue.Enqueue("Task3", 3);
        Assert.AreEqual("Task3", priorityQueue.Dequeue(), "Highest priority item should be Task3");
        Assert.AreEqual("Task2", priorityQueue.Dequeue(), "Next highest priority item should be Task2");
        Assert.AreEqual("Task1", priorityQueue.Dequeue(), "Last item should be Task1");




    }

    [TestMethod]
    // Scenario: Add an multiple items with the same priority to the queue.
    // When dequeued, they should be returned in the order they were added.
    // Expected Result: The expected order of dequeued items should match the order they were added.
    // Defect(s) Found: The dequeue meathod was not handling the case where multiple items have the 
    // same priority correctly, it was returning the last highest priority. By remove the = sign from
    //  the if statement, it would keep the first highest priority then return it.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 1);
        priorityQueue.Enqueue("Task3", 1);
        Assert.AreEqual("Task1", priorityQueue.Dequeue(), "First item should be Task1");
        Assert.AreEqual("Task2", priorityQueue.Dequeue(), "Second item should be Task2");
        Assert.AreEqual("Task3", priorityQueue.Dequeue(), "Last item should be Task3");
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: verify that the queue can handle empty queue operations.
    // Expected Result: An exception should be thrown when trying to dequeue from an empty queue.
    // Defect(s) Found: The dequeue meathod was not handling the case where the queue is empty correctly, it was not throwing an exception.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Dequeue should have thrown an exception when the queue is empty.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

 
}