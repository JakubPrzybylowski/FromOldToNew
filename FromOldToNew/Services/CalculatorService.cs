using System.Runtime.InteropServices;

namespace FromOldToNew.Services
{
    public class CalculatorService : ICalculatorService
    {
        [DllImport("NativeLibrary.dll")]
        public static extern double NativeAdd(double x, double y);
        public double Add(double x, double y)
        {
            return NativeAdd(x, y);
        }

        public double Divide(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Multiply(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double Subtract(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
