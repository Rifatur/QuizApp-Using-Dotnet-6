using Microsoft.EntityFrameworkCore;
using QuizCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizRespo;

public class AppDbCondext : DbContext
{
    public AppDbCondext ( DbContextOptions options ) : base(options)
    {

    }

    public DbSet<Question> questions { get; set; }



}

