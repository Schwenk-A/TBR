﻿using Ardalis.Specification.EntityFrameworkCore;
using Andrea.TBR.SharedKernel.Interfaces;

namespace Andrea.TBR.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
