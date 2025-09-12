/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run()
    {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases
        // Test 1
        // Scenario:Create the Queue with an invalid size, that is, 
        // with a value equal to or less than 0. 
        // Expected Result: The default size is default to 10.  

        Console.WriteLine("Test 1");
        var cs = new CustomerService(0);
        Console.WriteLine($"Size invalid default to 10: {cs}");

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Add a new customer
        // Expected Result: Enqueue a new customer into the queue.
        Console.WriteLine("Test 2");
        cs = new CustomerService(1);
        cs.AddNewCustomer();
        Console.WriteLine($"New customer added: {cs}");

        // Defect(s) Found: No defects

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: Add a customer in a queue full
        // Expected Result: An error message will be displayed. 
        Console.WriteLine("Test 3");
        cs = new CustomerService(2);
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        Console.WriteLine($"Service Queue: {cs}");

        // Defect(s) Found: Change >= instead of > in AddNewCustomer

        Console.WriteLine("=================");

        // Test 4
        // Scenario: The ServeCustomer function dequeue the next customer 
        // from the queue and display the details
        // Expected: The next customer from the queue is dequeue and the details are displayed
        Console.WriteLine("Test 4");
        cs = new CustomerService(3);
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        Console.WriteLine($"Before adding customers: {cs}");
        cs.ServeCustomer();
        Console.WriteLine($"After serving a customer: {cs}");

        // Defect(s) Found: No defects

        Console.WriteLine("=================");

        // Test 5
        // Scenario: The queue is empty when trying to serve a customer 
        // Expected Result: An error message will be displayed.

        Console.WriteLine("Test 5");
        cs = new CustomerService(2);
        cs.ServeCustomer(); 
        // Defect(s) Found:Check the length of the queue and display an error message       
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
        if (_queue.Count >= _maxSize) {
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
        if (_queue.Count <= 0)         {
            Console.WriteLine("No Customers in the queue");
        }
        else {            
            var customer = _queue[0];
            _queue.RemoveAt(0); 
            Console.WriteLine(customer);
        }
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