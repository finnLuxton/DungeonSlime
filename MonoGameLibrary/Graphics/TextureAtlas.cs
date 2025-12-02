using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameLibrary.Graphics;

public class TextureAtlas
{
    private Dictionary<string, TextureRegion> _regions;
    public Texture2D Texture { get; set; }

    public TextureAtlas()
    {
        _regions = new Dictionary<string, TextureRegion>();
    }

    public TextureAtlas(Texture2D texture)
    {
        Texture = texture;
        _regions = new Dictionary<string, TextureRegion>();
    }

    public void AddRegion(string name, int x, int y, int width, int height)
    {
        var textureRegion = new TextureRegion(Texture, x, y, width, height);
        _regions.Add(name, textureRegion);
    }

    public TextureRegion GetRegion(string name)
    {
        return _regions[name];
    }

    public bool RemoveRegion(string name)
    {
        return _regions.Remove(name);
    }

    public void Clear()
    {
        _regions.Clear();
    }

    public static TextureAtlas FromFile(ContentManager content, string fileName)
    {
        TextureAtlas atlas = new TextureAtlas();
        
        string filepath = Path.Combine(content.RootDirectory, fileName);

        using (Stream stream = TitleContainer.OpenStream(filepath))
        {
            using (XmlReader reader = XmlReader.Create(stream))
            {
                XDocument doc = XDocument.Load(reader);
                XElement root = doc.Root;
            }
        }

        return atlas;
    }
    
}