using efapi.Entities;

namespace efapi.Repository;

public interface IVideoGamesRepo
{
    Task AddVideoGameAsync(VideoGame game);

    Task<VideoGame> UpdateVideoGame(VideoGame game);

    void RemoveVideoGameAsync(string id);

    Task<VideoGame?> GetVideoGameAsync(string id);

    Task<List<VideoGame>> GelAllVideoGamesAsync();
}
