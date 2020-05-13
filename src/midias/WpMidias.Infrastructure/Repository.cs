﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace WpMidias.Infrastructure
{
    /// <summary>
    /// Metodos genericos responsaveis pela gravação e leitura das entidades de banco de dados 
    /// </summary>
    /// <typeparam name="T">Tipo da classe</typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// Busca todos itens salvo na base 
        /// </summary>
        /// <param name="navigationProperties">Classe operante</param>
        /// <returns>Lista baseada no tipo passado</returns>
        public virtual IList<T> GetAll()
        {
            List<T> list;

            var context = new WpMidiasContext();
            IQueryable<T> dbQuery = context.Set<T>();

            list = dbQuery
                .ToList<T>();

            return list;
        }
        /// <summary>
        /// Usado para pegar todos utilizando Lambda Expression
        /// </summary>
        /// <param name="where">Sintaxe where para selecionar uma clausula</param>
        /// <param name="navigationProperties">Classe Operante</param>
        /// <returns>Lista filtrada</returns>
        public virtual IList<T> GetList(Func<T, bool> where,
             params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list = new List<T>();
            var context = new WpMidiasContext();
            IQueryable<T> dbQuery = context.Set<T>();

            //Apply eager loading

            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include<T, object>(navigationProperty);

            list = dbQuery
                .AsNoTracking()
                .Where(where)
                .ToList<T>();


            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        public virtual T GetSingle(Func<T, bool> where,
             params Expression<Func<T, object>>[] navigationProperties)
        {
            T item = null;
            var context = new WpMidiasContext();
            IQueryable<T> dbQuery = context.Set<T>();

            //Apply eager loading
            foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include<T, object>(navigationProperty);

            item = dbQuery
                .AsNoTracking() //Don't track any changes for the selected item
                .FirstOrDefault(where); //Apply where clause

            return item;
        }
        /// <summary>
        /// Adiciona um item na base de dados 
        /// </summary>
        /// <param name="items">Baseado na classe operante</param>
        public virtual IEnumerable<T> Add(params T[] items)
        {
            var context = new WpMidiasContext();

            foreach (var item in items)
            {
                context.Entry(item).State = EntityState.Added;
            }

            context.SaveChanges();

            return items;
        }
        /// <summary>
        /// Atualiza um item na base de dados 
        /// </summary>
        /// <param name="items">Item Operantante pode se passar um unique ou lista de objetos a ser salvo</param>
        public virtual void Update(params T[] items)
        {
            var context = new WpMidiasContext();

            foreach (T item in items)
            {
                context.Entry(item).State = EntityState.Modified;
            }

            context.SaveChanges();
        }
        /// <summary>
        /// Remove um objeto da base dados 
        /// </summary>
        /// <param name="items">Item Operantante pode se passar um unique ou lista de objetos a ser salvo</param>
        public virtual void Remove(params T[] items)
        {
            var context = new WpMidiasContext();

            foreach (T item in items)
            {
                context.Entry(item).State = EntityState.Deleted;
            }

            context.SaveChanges();
        }
    }
}