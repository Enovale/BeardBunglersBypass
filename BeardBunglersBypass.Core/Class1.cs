using GvasFormat;
using GvasFormat.Serialization;

namespace BeardBunglersBypass.Core;

public class Class1
{
    public Class1()
    {
        Gvas sav;
        using (var stream = File.Open("/home/games/steam/steamapps/common/Deep Rock Galactic/FSD/Saved/SaveGames/76561198073976871_Player.sav", FileMode.Open, FileAccess.Read, FileShare.Read))
            sav = UESerializer.Read(stream);
        Console.WriteLine(sav.EngineVersion);
    }
}