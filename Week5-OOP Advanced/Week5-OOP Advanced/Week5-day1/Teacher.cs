namespace Week5_OOP_Advanced.Week5_day1
{
    public class Teacher
    {
        public string name;
        public string email;
        private string password;
        private int salary;

        public string Name          //auto-implemented property
        {
            get; set;           //poti atat lua cat si da o valoare 
        }

        public string Email
        {
            get; set;
        }
        public Teacher()
        {
        }
        public void SetSalary(int salary)
        {
            if (salary < 0)
            {
                throw new Exception("Salary is invalid.");
            }
            this.salary = salary;
        }
        public void SetPassword(string password)
        {
            SaveToDatabase(EncryptPassword(password));
        }
        private void SaveToDatabase(string encryptedPassword)
        {
            throw new NotImplementedException();
        }
        private string EncryptPassword(string password)
        {
            throw new NotImplementedException();
        }

        //Private methods
    }
}
