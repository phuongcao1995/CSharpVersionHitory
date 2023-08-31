namespace AwaitCatchFinallyBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath obj = new MyMath();
            obj.Div(12, 0);
            Console.ReadLine();
        }
    }
    public class MyMath
    {
        public async void Div(int value1, int value2)
        {
            try
            {
                int res = value1 / value2;
                Console.WriteLine("Div : {0}", res);
            }
            catch (Exception ex)
            {
                await AsyncMethodForCatch();
            }
            finally
            {
                await AsyncMethodForFinally();
            }
        }
        private async Task AsyncMethodForFinally()
        {
            Console.WriteLine("Method from async finally Method !!");
        }

        private async Task AsyncMethodForCatch()
        {
            Console.WriteLine("Method from async Catch Method !!");
        }
    }
}