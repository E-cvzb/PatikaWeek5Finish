namespace PatikaWeek5Finish
{
    public class Cars
    {
        public string carNumber { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string colour { get; set; }
        public int doorNumber { get; set; }
        public DateTime date { get; set; }

        public override string ToString()
        {
            return carNumber + "-" + brand;
        }

    }
}
