using Cenco.Backend.DataContext.Interfaces;
using Cenco.Backend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cenco.Backend.DataContext
{
	public class UserRepository : IRepository<Usuario>
	{
		readonly DataContext _dbContext = new();

		public UserRepository(DataContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<Usuario> List()
		{
			return _dbContext.Usuarios.ToList();
		}
		public List<Usuario> ListBy(Expression<Func<Usuario, bool>> expression)
		{
			return _dbContext.Usuarios.Where(expression).ToList();
		}
		public Usuario Get(long id)
		{
			Usuario? model = _dbContext.Usuarios.Find(id);
			if (model != null)
			{
				return model;
			}
			else
			{
				throw new ArgumentNullException();
			}
		}
		public void Add(Usuario model)
		{
			try
			{
				_dbContext.Usuarios.Add(model);
				_dbContext.SaveChanges();
			}
			catch (Exception ex)
			{
				throw;
			}
		}
		public void Update(Usuario model)
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
		public Usuario Delete(long id)
		{
			try
			{
				Usuario? model = _dbContext.Usuarios.Find(id);

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
