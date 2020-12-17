namespace ExceptionsLibrary
{
    public class Person
    {
        public int Age { get; }
        public string Name { get; }
        public string Gender{ get; }

        public Person(string name, string gender, string age)
        {
            Name = name;

            if (gender.CompareTo("Male") == 0 ||
                gender.CompareTo("Female") == 0)
            {
                Gender = gender;
            }
            else
            {
                throw new WrongGenderException("Incorrect meaning of gender", gender);
            }

            int ageValue;
            if (int.TryParse(age, out ageValue) && ageValue >= 0)
            {
                Age = ageValue;
            }
            else
            {
                throw new PersonNotCreatedException($"Person cannot be created name : {name}, gender : {gender}, age : {age}");
            }
        }

        public override string ToString()
        {
            return $"Name : {Name}, Gender : {Gender}, Age : {Age}";
        }
    }
}
