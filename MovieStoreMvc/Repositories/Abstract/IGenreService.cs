using MovieStoreMvc.Models.Domain;
using MovieStoreMvc.Models.DTO;

namespace MovieStoreMvc.Repositories.Abstract
{
    public interface IGenreService
    {
       bool Add(Genre model);
       bool Update(Genre model);
       Genre GetById(int id);
       bool Delete(int id);
       IQueryable<Genre> List();

    }
}
