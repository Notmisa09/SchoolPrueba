using School.Domain.ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.REPOSITORY
{
    public interface IStudentsRepository
    {
        void Remove(Students student);
        void Save(Students student);
        void Update(Students student);
        void GetstudentsID (Students studentID);
        List<Students> GetAll();
    }
}
