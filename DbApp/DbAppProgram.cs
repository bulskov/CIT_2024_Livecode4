

using DataLayer;

var dataservice = new DataService();

var categories = dataservice.GetCategories();

foreach(var e in categories)
{
    Console.WriteLine(e.Name);
}