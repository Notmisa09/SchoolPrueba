using School.Domain.ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.REPOSITORY
{
    public interface IInstructorRepository
    {
        void Remove(Instructor instructor);
        void Save(Instructor instructor);
        void Update(Instructor instructor);
        Instructor GetInstructor(int Id);
        List<Instructor> GetAll();
    }
}
