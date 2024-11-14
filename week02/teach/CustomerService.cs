/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: invalid amount (less than or equal to 0) default size 10 add a new customer
        // Expected Result: Service Queue initial amount 10
        Console.WriteLine("Test 1");

        // Defect(s) Found:
        var newCustomerService = new CustomerService(0);

        Console.WriteLine(newCustomerService._maxSize == 10);


        Console.WriteLine("=================");

        // Test 2
        // Scenario:adding new customers
        // Expected Result: if the size of the queue is 1
        Console.WriteLine("Test 2");

        // // Defect(s) Found:
        newCustomerService.AddNewCustomer();
        Console.WriteLine(newCustomerService._queue.Count == 1);

        Console.WriteLine("=================");


        // Test 3
        // Scenario:adding new customers
        // Expected Result: if the size of the queue is 1
        Console.WriteLine("Test 3");

        var newCustomerService1 = new CustomerService(0);

        // Defect(s) Found:
        newCustomerService1.AddNewCustomer();
        Console.WriteLine(newCustomerService1._queue.Count == 1);

        newCustomerService1.ServeCustomer();
        Console.WriteLine(newCustomerService1._queue.Count == 0);


        Console.WriteLine("=================");


        // Test 3
        // Scenario:adding 11 new customers
        // Expected Result: Error
        Console.WriteLine("Test 3");

        // Defect(s) Found:

        // var secondCustomerService = new CustomerService(0);

        // for (int i = 1; i<= 10 ; i++)
        // {
        //   secondCustomerService.AddNewCustomer();
        // }

        // Console.WriteLine("The queue has 10 customers");
        // Console.WriteLine(secondCustomerService._queue.Count == 10);

        // secondCustomerService.AddNewCustomer();
        // Console.WriteLine("The queue has 10 customers after the error");
        // Console.WriteLine(secondCustomerService._queue.Count == 10);

        // Console.WriteLine("=================");
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        _queue.RemoveAt(0);
        var customer = _queue[0];
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}