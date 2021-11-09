// 2021-11-08, Darius Patiejunas, vartutechnika
namespace ClassLibrary4
{
    internal interface IWebDriver
    {
        object Navigate();
        object Manage();
        object FindElement(object p);

        string Url { get; set; }
    }
}