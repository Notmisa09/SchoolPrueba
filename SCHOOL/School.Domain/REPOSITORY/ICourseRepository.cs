using School.Domain.ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.REPOSITORY
{
    public interface ICourseRepository
    {
        void Save(Course course);
        void Update(Course course);
        void Remove(Course course);
        void GetCourseID (Course course);
        List<Course> GetCourses();
    }
}
