using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            // {    2023 07 03 Add user input / Beta
            string userInput = string.Empty;
            Console.WriteLine("This program converc Cm to Inch");
            Console.WriteLine("Input Cm value : ");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            ruler.Run();
            // }    2023 07 03 Add user input / Beta
        }
    }

    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        private int Centimeter { get; set; } = 0;

        public float Inch
        {
            get
            {
                return Centimeter * ONE_INCH;
            }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }

        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }
    }

    private void _SetInch(float inchValue)
    {
        Centimeter = (int)(inchValue / ONE_INCH);
    }
    // {    2023 07 03          Add private _SetInch function / Gamma
    // }     2023 07 03 Modified class position / Alpha
}
