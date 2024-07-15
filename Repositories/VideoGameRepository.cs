using efapi.Data;
using efapi.Entities;
using efapi.Interfaces;

namespace efapi.Repositories;

public class VideoGameRepository(DataContext context) : GenericRepository<VideoGame>(context), IVideoGameRepository
{
    public IEnumerable<VideoGame> GetPopularGames(int count)
    {
        return context.VideoGames.OrderByDescending(g => g.Rating).Take(count).ToList();
    }
}