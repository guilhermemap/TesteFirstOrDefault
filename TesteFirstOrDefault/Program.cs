// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<Customer> list = [
    new Customer() {    Id = 1,    Name = "First",    Email="First@gmail.com"},
    new Customer() {    Id = 2,    Name = "Second",    Email="Second@gmail.com"},
    new Customer() {    Id = 3,    Name = "Third",    Email="Third@gmail.com"},
];
List<int> intList = [1, 2, 3, 4];

var firstCustomer = list.FirstOrDefault(c => c.Id == 5); // null
var firstInt = intList.FirstOrDefault(i => i == 6); // 0


try
{
    var oops = list.First(c => c.Id == 5);
}
catch (Exception ex)
{
    Console.WriteLine("first(): " + ex.Message);
}
