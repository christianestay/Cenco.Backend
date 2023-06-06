using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cenco.Backend.DataContext.Interfaces
{
	public interface IRepository<T>
	{
		public List<T> List();
		public List<T> ListBy(Expression<Func<T, bool>> expression);
		public T Get(long id);
		public void Add(T model);
		public void Update(T model);
		public T Delete(long id);
	}
}
