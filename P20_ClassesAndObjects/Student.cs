namespace P20_ClassesAndObjects
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;
        public Student(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            this.gpa = gpa;
        }

        public bool HasHonours()
        {
            bool hasHonours;
            if(this.gpa > 3.5)
            {
                hasHonours = true;
            }
            else
            {
                hasHonours = false;
            }
            return hasHonours;
        }
    }
}
