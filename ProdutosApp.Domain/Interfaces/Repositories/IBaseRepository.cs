﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable
        where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        List<TEntity> GetAll();
        TEntity? GetById(int id);
    }
}