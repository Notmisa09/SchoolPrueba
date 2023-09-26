using School.Domain.ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.REPOSITORY
{
    public interface IInstructorRepository
    {
        void Save(Instructor instructor);
        void Update(Instructor instructor);
        void Remove(Instructor instructor);
        void GetCourseID(Instructor instructor);
        List<Instructor> GetCourses();
    }
}
