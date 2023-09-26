using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using School.Domain.ENTITIES;
using School.Domain.REPOSITORY;
using School.Infraestructure.CONTEXT;

namespace School.Infraestructure.REPOSITORY
{
    public class InstructorRespository : IInstructorRepository
    {
        private readonly SchoolContext context;

        public InstructorRespository(SchoolContext context)
        {
            this.context = context;
        }

        public Instructor Getinstructor(int Id)
        {
            return context.Instructors.Find(Id);
        }

        public List<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void Save(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}