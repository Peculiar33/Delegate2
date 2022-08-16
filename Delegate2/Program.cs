namespace Delegate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var Delegate  = new Delegate();
            Delegate.iCloudSaver(DataUpload);
        }
        public static void DataUpload(int DU)
        {
            Console.WriteLine($"so far {DU} done");
 
    }   }
}
