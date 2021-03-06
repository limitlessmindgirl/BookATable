﻿using DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Repositories;
using System.Linq.Expressions;

namespace BookATableMVC.Services.EntityServices
{
    public class BaseService<T> where T: BaseEntity, new()
    {
        private BaseRepository<T> Repository { get; set; }
        public BaseService()
        {
            this.Repository = new BaseRepository<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return this.Repository.GetAll();
        }
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return this.Repository.GetAll(filter);
        }
        public T GetById(int id)
        {
            return this.Repository.GetById(id);
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
            return this.Get(filter);
        }
        public void Save(T entity)
        {
            this.Repository.Save(entity);
        }
        public void Delete(T entity)
        {
            this.Repository.Delete(entity);
        }
    }
}