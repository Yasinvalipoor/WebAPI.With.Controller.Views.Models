using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Controller.View.Models;

public partial class WebApiControllerViewContext : DbContext
{
    public DbSet<Person> people { get; set; }


    public WebApiControllerViewContext()
    {
    }

    public WebApiControllerViewContext(DbContextOptions<WebApiControllerViewContext> options)
        : base(options)
    {
    }
}
