namespace BidirectionalObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { Name = "Iphone 5" };
            Window window = new Window() { ProductName = "Apple" };

            //product.PropertyChanged += (sender, eventArgs) =>
            //    {
            //        if (eventArgs.PropertyName == "Name")
            //        {
            //            System.Console.WriteLine("Window.ProductName changed in Product");
            //            window.ProductName = product.Name;
            //        }
            //};

            //window.PropertyChanged += (sender, eventArgs) =>
            //{
            //    if(eventArgs.PropertyName =="ProductName")
            //    {
            //        System.Console.WriteLine("Product.Name changed in Window");
            //        product.Name = window.ProductName;
            //    }
            //};

            var binding = new BidirectionalBinding(product, () => product.Name, window, () => window.ProductName);

            product.Name = "Smart Tablet";
            System.Console.WriteLine(product);
            System.Console.WriteLine(window);
        }
    }
}
