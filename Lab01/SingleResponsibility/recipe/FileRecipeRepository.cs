// FileRecipeRepository.cs
using System.IO;

public class FileRecipeRepository
{
    public void Save(string path, string contents)
    {
        using (StreamWriter writer = new StreamWriter(path, false))
        {
            writer.Write(contents);
        }
    }
}
