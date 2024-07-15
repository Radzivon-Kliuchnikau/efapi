using efapi.Entities;

namespace efapi.Interfaces;

public interface IVideoGameRepository : IGenericRepository<VideoGame>
{
    IEnumerable<VideoGame> GetPopularGames(int count);
}