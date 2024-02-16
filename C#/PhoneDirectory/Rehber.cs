namespace Directory
{
    public class Person
    {
        private string name;
        private string surname;
        private string number;

        public Person (){}
        public Person (string Name, string Surname, string Number){
            this.Name = Name;
            this.Surname = Surname;
            this.Number = Number;
        }

        public global::System.String Name { get => name; set => name = value; }
        public global::System.String Surname { get => surname; set => surname = value; }
        public global::System.String Number { get => number; set => number = value; }
    }
}