namespace WritersExam
{

    public partial class Books
    {

        public int id { get; set; }
        public string name { get; set; }
        public string publishDay { get; set; }

        public int? rating { get; set; }

        public int GenreID { get; set; }
    }
}
