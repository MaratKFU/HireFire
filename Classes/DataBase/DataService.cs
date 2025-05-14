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
            return _context.JobSeekers
                    .Include(js => js.Resumes)
                    .FirstOrDefault(js => js.Id == id);
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
            return _context.Employers
                    .Include(js => js.Vacancies)
                    .FirstOrDefault(js => js.Id == id);
        }

        public void SaveResume(Resume resume)
        {
            if (resume.Id == 0)
                _context.Resumes.Add(resume);
            else
                _context.Entry(resume).State = EntityState.Modified;

            _context.SaveChanges();
        }
        public Resume GetResume(int id)
        {
            return _context.Resumes.Find(id);
        }
        public void Dispose() => _context?.Dispose();
    }
}
