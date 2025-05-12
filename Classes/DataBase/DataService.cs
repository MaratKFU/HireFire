using HireFire.Classes.Entities;
using Microsoft.EntityFrameworkCore;

namespace HireFire.Classes.DataBase
{
    public class DataService : IDisposable
    {
        private readonly AppDbContext _context = new();

        public void SaveJobSeeker(JobSeeker jobSeeker)
        {
            if (jobSeeker.Id == 0)
                _context.JobSeekers.Add(jobSeeker);
            else
                _context.Entry(jobSeeker).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public JobSeeker GetJobSeeker(int id)
        {
            return _context.JobSeekers.Find(id);
        }

        // Аналогичные методы для Employer
        public void SaveEmployer(Employer employer)
        {
            if (employer.Id == 0)
                _context.Employers.Add(employer);
            else
                _context.Entry(employer).State = EntityState.Modified;

            _context.SaveChanges();
        }

        public Employer GetEmployer(int id)
        {
            return _context.Employers.Find(id);
        }

        public void Dispose() => _context?.Dispose();
    }
}
