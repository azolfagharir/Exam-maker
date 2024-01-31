using Microsoft.EntityFrameworkCore;

namespace QuizHub.Context;

public class QuizHubContext:DbContext
{
    public QuizHubContext(DbContextOptions<QuizHubContext> options):base(options)
    {
        
    }
    
}