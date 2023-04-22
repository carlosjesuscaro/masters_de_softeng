// Associations

namespace Class_Three;

// Horizontal relationship: association
internal class Teacher
{
    public List<Student> course_participant { get; } 

    public Teacher()
    {
        this.course_participant = new List<Student>();
    }

    public void TeachTo(Student std)
    {
        if (!this.course_participant.Contains(std))
        {
            this.course_participant.Add(std);
            std.startClass(this);
        }
    }

    public bool stopTeach(Student std)
    {
        return this.course_participant.Remove(std);
        std.stopClass(this);
    }
    
    
}