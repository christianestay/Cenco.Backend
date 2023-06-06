using Cenco.Backend.DataContext.Interfaces;
using Cenco.Backend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cenco.Backend.DataContext
{
	public class TareaRepository : IRepository<Tarea>
	{
		readonly DataContext _dbContext = new();

		public TareaRepository(DataContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<Tarea> List()
		{
			return _dbContext.Tareas.ToList();
		}
		public List<Tarea> ListBy(Expression<Func<Tarea, bool>> expression)
		{
			return _dbContext.Tareas.Where(expression).ToList();
		}
		public Tarea Get(long id)
		{
			Tarea? model = _dbContext.Tareas.Find(id);
			if (model != null)
			{
				return model;
			}
			else
			{
				throw new ArgumentNullException();
			}
		}
		public void Add(Tarea model)
		{
			try
			{
				_dbContext.Tareas.Add(model);
				_dbContext.SaveChanges();
			}
			catch (Exception ex)
			{
				throw;
			}
		}
		public void Update(Tarea model)
		{
			try
			{
				_dbContext.Entry(model).State = EntityState.Modified;
				_dbContext.SaveChanges();
			}
			catch
			{
				throw;
			}
		}
		public Tarea Delete(long id)
		{
			try
			{
				Tarea? model = _dbContext.Tareas.Find(id);

				if (model != null)
				{

					model.fecha_eliminacion = DateTime.Now;
					_dbContext.Entry(model).State = EntityState.Modified;
					_dbContext.SaveChanges();
					return model;
				}
				else
				{
					throw new ArgumentNullException();
				}
			}
			catch
			{
				throw;
			}
		}
	}
}
