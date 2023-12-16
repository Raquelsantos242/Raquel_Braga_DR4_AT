using MeuMiniMuseu.Data.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace MeuMiniMuseu.Data
{
	public class RepositoryPainting : IRepositoryPainting

	{
		private ArtContext _context;
		public RepositoryPainting(ArtContext context) 
		{
			_context = context;
		}
		public List<Pintura> GetAll()
		{
			return _context.Pintura.ToList();
		}
		public void Add(Pintura pintura)
		{
			_context.Pintura.Add(pintura);
			_context.SaveChanges();
		}
		public void Delete(int id)
		{

			var deleteItem = _context.Pintura.FirstOrDefault(x => x.Id == id);

			if (deleteItem != null)
			{
				_context.Pintura.Remove(deleteItem);
				_context.SaveChanges();
			}

		}
		public Pintura GetById(int id)
		{
			return _context.Pintura.FirstOrDefault(_ => _.Id == id);
		}

		public void Update(Pintura pintura)
		{
			_context.Entry(pintura).State = EntityState.Modified;
			_context.SaveChanges();
		}
	}
}
	
