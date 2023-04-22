namespace Class_Three;

// Horizontal relationship: association
internal class Student
{
    public List<Teacher> Teachers { get; }
    
    public Student(Teacher teach)
    {
        this.Teachers = new List<Teacher>();
        // To respect the cardinality of at least have 1
        this.Teachers.Add(teach);   
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
