using HireFire.Classes.Entities;
using Microsoft.EntityFrameworkCore;

namespace HireFire.Classes.DataBase
{
    public class DataService : IDisposable
    {
        private readonly AppDbContext _context = new();

        public int SaveJobSeeker(JobSeeker jobSeeker)
        {
            if (jobSeeker.Id == 0)
                _context.JobSeekers.Add(jobSeeker);
            else
                _context.Entry(jobSeeker).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return jobSeeker.Id;

            }
            return jobSeeker.Id;
        }
        public JobSeeker GetJobSeeker(int id)
        {
            return _context.JobSeekers
                    .Include(js => js.Resumes)
                    .FirstOrDefault(js => js.Id == id);
        }

        public int SaveEmployer(Employer employer)
        {
            if (employer.Id == 0)
                _context.Employers.Add(employer);
            else
                _context.Entry(employer).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return employer.Id;
            }

            return employer.Id;
        }
        public Employer GetEmployer(int id)
        {
            return _context.Employers
                    .Include(js => js.Vacancies)
                    .FirstOrDefault(js => js.Id == id);
        }
        
        
        public int SaveResume(Resume resume)
        {
            if (resume.Id == 0)
                _context.Resumes.Add(resume);
            else
                _context.Entry(resume).State = EntityState.Modified;
            
            _context.SaveChanges();
            
            return resume.Id;
        }
        public Resume GetResume(int id)
        {
            return _context.Resumes.Find(id);
        }


        public int SaveVacancy(Vacancy vacancy)
        {
            if (vacancy.Id == 0)
            {
                _context.Vacancies.Add(vacancy);
            }
            else
            {
                _context.Entry(vacancy).State = EntityState.Modified;
            }
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return vacancy.Id;
            }
            return vacancy.Id;
        }
        public Vacancy GetVacancy(int id)
        {
            return _context.Vacancies.Find(id);
        }


        public int SaveDialog(MyDialog dialog)
        {
            if (GetDialog(dialog.EmployerId, dialog.JobSeekerId) == null)
            {
                _context.Dialogs.Add(dialog);
            }
            else
            {
                _context.Entry(dialog).State = EntityState.Modified;
            }
            try
            {
                _context.SaveChanges();
            }
            catch(Exception)
            {
                return dialog.Id;
            }
            return dialog.Id;
        }
        public MyDialog GetDialog(int employerId, int jobSeekerId)
        {
            return _context.Dialogs.FirstOrDefault(d => d.EmployerId == employerId && d.JobSeekerId == jobSeekerId);
        }

        public MyDialog GetDialog(int id)
        {
            return _context.Dialogs.Find(id);
        }

        public UserMessage GetMessage(int id)
        {
            return _context.Messages.Find(id);
        }
        public int SaveMessage(UserMessage message)
        {
            _context.Messages.Add(message);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Запишите InnerException для диагностики
                MessageBox.Show("Ошибка: " + ex.InnerException?.Message);
            }
            return message.Id;
        }
        public void Dispose() => _context?.Dispose();
    }
}
