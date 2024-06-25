using efapi.Data;
using efapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace efapi.Repository;

public class VideoGamesRepo : IVideoGamesRepo
{
    private readonly DataContext _context;

    public VideoGamesRepo(DataContext context)
    {
        _context = context;
    }

    public async Task AddVideoGameAsync(VideoGame game)
    {
        await _context.VideoGames.AddAsync(game);

        await _context.SaveChangesAsync();
    }

    public async Task<List<VideoGame>> GelAllVideoGamesAsync()
    {
        var videoGames = await _context.VideoGames.ToListAsync();

        return videoGames;
    }

    public async Task<VideoGame?> GetVideoGameAsync(string id)
    {
        var videoGame = await _context.VideoGames.FindAsync(id);

        return videoGame;
    }

    public void RemoveVideoGameAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<VideoGame> UpdateVideoGame(VideoGame game)
    {
        var videoGame = await _context.VideoGames.FindAsync(game.Id);

        videoGame.Name = game.Name;
        videoGame.Description = game.Description;
        videoGame.Genre = game.Genre;
        videoGame.Platforms = game.Platforms;
        videoGame.Publisher = game.Publisher;
        videoGame.Rating = game.Rating;

        await _context.SaveChangesAsync();

        return videoGame;
    }
}
