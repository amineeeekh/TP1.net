﻿namespace TP1.Models.Repositories.IRepository
{
    namespace tp1.Models.Repositories
    {
        public interface IRepository<T>
        {
            double SalaryAverage();
            double MaxSalary();
            int HrEmployeesCount();
            IList<T> GetAll();
            T FindByID(int id);
            void Add(T entity);
            void Update(int id, T entity);
            void Delete(int id);
            List<T> Search(string term);
        }
    }
}
