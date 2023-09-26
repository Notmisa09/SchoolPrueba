using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.REPOSITORY
{
    public interface IBaseRepository <T> where  T : class
    {
        void Save(T entity);
        void Update(T entity);
        void Remove(T entity);
        List<T> GetEntities();
        T GetEntity(int Id);
    }
}
