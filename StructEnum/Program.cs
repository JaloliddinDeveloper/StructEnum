using StructEnum.Struct;

var students = new List<Student>
{
    new Student{ Id=1,FirstName="Ali",Age=20,Gender=GenderType.Mele,Cource=Cource.Fourth},
    new Student{ Id=2,FirstName="Vali",Age=21,Gender=GenderType.Mele,Cource=Cource.Second},
    new Student{ Id=3,FirstName="Asal",Age=18,Gender=GenderType.Female,Cource=Cource.Treth},
    new Student{ Id=4,FirstName="Guzal",Age=19,Gender=GenderType.Female,Cource=Cource.First},
};


foreach (var s in students)
{
    s.DisplayDataStudent();
}