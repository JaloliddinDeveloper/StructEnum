namespace StructEnum.Struct
{
    internal struct Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public Cource Cource { get; set; }

        public Student(int id, string firstName, int age, GenderType gender, Cource cource)
        {
            Id = id;
            FirstName = firstName;
            Age = age;
            Gender = gender;
            Cource = cource;
        }
       public void DisplayDataStudent()
        {
            Console.WriteLine($"Id: {Id} \nFirstName: {FirstName}\n" +
                $"Age: {Age} \nGenderType: {Gender} \nCource: {Cource}");
        }
    }
}
