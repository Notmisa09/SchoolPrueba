using School.Domain.ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.REPOSITORY
{
    public interface IStudentsRepository
    {
        void Save(Students students);
        void Update(Students students);
        void Remove(Students students);
        void GetCourseID(Students students);
        List<Students> GetCourses();
    }
}
