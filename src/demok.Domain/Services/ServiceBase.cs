﻿using demok.Domain.Repositories;
using demok.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace demok.Domain.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        protected IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public virtual TEntity Add(TEntity obj)
        {
            return _repositoryBase.Add(obj);
        }
        
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public virtual TEntity GetById(object id)
        {
            return _repositoryBase.GetById(id);
        }

        public virtual void Remove(TEntity obj)
        {
            _repositoryBase.Remove(obj);
        }

        public virtual void Update(TEntity obj)
        {
            _repositoryBase.Update(obj);
        }
    }
}
