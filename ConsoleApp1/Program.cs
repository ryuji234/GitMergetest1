namespace GitMergeTest
{
    internal class program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter*ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }   
        }
        public Ruler(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }

    }

}

