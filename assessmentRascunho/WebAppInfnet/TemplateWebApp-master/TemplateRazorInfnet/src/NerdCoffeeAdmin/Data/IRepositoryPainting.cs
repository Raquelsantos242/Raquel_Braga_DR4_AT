using MeuMiniMuseu.Data.Models;

namespace MeuMiniMuseu.Data
{
	public interface IRepositoryPainting
	{
		public List<Pintura> GetAll();

		public void Add(Pintura pintura);

		public void Update(Pintura pintura);

		public void Delete(int id);

		public Pintura GetById(int id);

	}
}
