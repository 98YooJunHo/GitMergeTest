using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTest
{
    // {    2023 07 03 Modified class position / Alpha
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
        // {    2023 07 03          Add private _SetInch function / Gamma
            private set { this._SetInch(value); }
        }

        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }

        private void _SetInch(float inchValue)
        {
            Centimeter = (int)(inchValue / ONE_INCH);
        }
        // {    2023 07 03          Add private _SetInch function / Gamma
    }
    // }     2023 07 03 Modified class position / Alpha
}
