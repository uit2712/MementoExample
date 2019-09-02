namespace UpdateInfo
{
    class UserInfo
    {
        public UserInfo(string name, int age, string gender, string job, string address)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Job = job;
            Address = address;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
    }
}
