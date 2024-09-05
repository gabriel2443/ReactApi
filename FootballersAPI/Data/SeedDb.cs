using FootballersAPI.Models;

namespace FootballersAPI.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task Seed()
    {
        await _context.Database.EnsureDeletedAsync();
        await _context.Database.EnsureCreatedAsync();

        var players = new List<Player>
    {
              new Player()
        {
            Name = "Lionel Messi",
            Age = 37,
            Img = "https://upload.wikimedia.org/wikipedia/commons/b/b4/Lionel-Messi-Argentina-2022-FIFA-World-Cup_%28cropped%29.jpg",
            Country = "Argentina"
        },

        new Player()
        {
            Name = "Cristiano Ronaldo dos Santos Aveiro",
            Age = 39,
            Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Cristiano_Ronaldo_playing_for_Al_Nassr_FC_against_Persepolis%2C_September_2023_%28cropped%29.jpg/800px-Cristiano_Ronaldo_playing_for_Al_Nassr_FC_against_Persepolis%2C_September_2023_%28cropped%29.jpg",
            Country = "Portugal"
        },
        new Player()
        {
            Name = "Gianluigi \"Gigi\" Buffon",
            Age = 46,
            Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Gianluigi_Buffon_%2831784615942%29_%28cropped%29.jpg/800px-Gianluigi_Buffon_%2831784615942%29_%28cropped%29.jpg",
            Country = "Italy"
        },
        new Player()
        {
            Name = "Xavier Hernández Creus",
            Age = 44,
            Img = "https://upload.wikimedia.org/wikipedia/commons/5/53/Xavi_13981129001173637176666027076571.jpg",
            Country = "Spain"
        },
        new Player()
        {
            Name = "Roberto Carlos da Silva Rocha",
            Age = 51,
            Img = "https://upload.wikimedia.org/wikipedia/commons/a/a8/LS3_1288_%2853332367864%29_%28cropped%29.jpg",
            Country = "Brazil"
        },
        new Player()
        {
            Name = "Iker Casillas Fernández",
            Age = 43,
            Img = "https://upload.wikimedia.org/wikipedia/commons/c/c8/Iker-Casillas-SportsTrade-2021-cropped.jpg",
            Country = "Spain"
        },
        new Player()
        {
            Name = "Daniel \"Dani\" Alves da Silva",
            Age = 41,
            Img = "https://upload.wikimedia.org/wikipedia/commons/d/dd/07_07_2019_Final_da_Copa_Am%C3%A9rica_2019_%2848226649586%29_%28cropped%29.jpg",
            Country = "Brazil"
        }
    };

        await _context.AddRangeAsync(players);
        await _context.SaveChangesAsync();
    }
}