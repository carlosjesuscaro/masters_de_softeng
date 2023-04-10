namespace Class_Three;


internal class Student
{
    public List<Teacher> Teachers { get; }
    
    public Student()
    {
        this.Teachers = new List<Teacher>();
    }

    public void startClass(Teacher teacher)
    {
        if (!this.Teachers.Contains(teacher))
        {
            this.Teachers.Add(teacher);
            
        }
    }

    public bool stopClass(Teacher teacher)
    {
        return this.Teachers.Remove(teacher);
    }

}
