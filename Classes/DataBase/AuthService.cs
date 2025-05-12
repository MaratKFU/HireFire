using HireFire.Classes.Entities;

namespace HireFire.Classes.DataBase;
public class AuthService
{
    private readonly AppDbContext _context;

    public AuthService(AppDbContext context)
    {
        _context = context;
    }

    public Employer AuthenticateEmployer(string login, string password)
    {
        var employer = _context.Employers
            .FirstOrDefault(e => e.Login == login);

        return employer != null && BCrypt.Net.BCrypt.Verify(password, employer.PasswordHash)
            ? employer
            : null;
    }

    public JobSeeker AuthenticateJobSeeker(string login, string password)
    {
        var jobSeeker = _context.JobSeekers
            .FirstOrDefault(j => j.Login == login);

        return jobSeeker != null && BCrypt.Net.BCrypt.Verify(password, jobSeeker.PasswordHash)
            ? jobSeeker
            : null;
    }
}