class Menu
{
    private List<Scripture> _scriptures;

    public Menu()
    {
        _scriptures = new List<Scripture>();
        _scriptures.Add(new Scripture("Genesis",1,1,"In the beginning God created the heaven and the earth."));
        _scriptures.Add(new Scripture("John",3,16,17,"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved."));
        _scriptures.Add(new Scripture("1 Nephi",13,9,"And the world, because of their iniquity, shall judge him to be a thing of naught; wherefore they scourge him, and he suffereth it; and they smite him, and he suffereth it. Yea, they spit upon him, and he suffereth it, because of his loving kindness and his long-suffering towards the children of men."));
        _scriptures.Add(new Scripture("D&C",84,54,57,"And your minds in times past have been darkened because of unbelief, and because you have treated lightly the things you have received— Which vanity and unbelief have brought the whole church under condemnation. And this condemnation resteth upon the children of Zion, even all. And they shall remain under this condemnation until they repent and remember the new covenant, even the Book of Mormon and the former commandments which I have given them, not only to say, but to do according to that which I have written"));
        _scriptures.Add(new Scripture("Moses",1,39,"For behold, this is my work and my glory— to bring to pass the immortality and eternal life of man."));
    }

    public Menu(List<Scripture> scriptures)
    {
        _scriptures = scriptures;
    }

    public Scripture AddScripture(Scripture scripture)
    {
        if (scripture != null)
        {
            _scriptures.Add(scripture);
        }
        return scripture;
    }

    public Scripture GetScripture(int option)
    {
        if (option >= 2 && option < _scriptures.Count() + 2)
        {
            return _scriptures[option - 2];
        }
        else
        {
            return null;
        }
    }

    public void ShowMenu()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine();

        int i = 2;
        foreach(Scripture scripture in _scriptures)
        {
            Console.WriteLine($"    {i}. {scripture.GetReference()}");
            i++;
        }

        Console.WriteLine("    1. Add Your Own Scripture!");
        Console.WriteLine("    0. Quit");
        Console.WriteLine();
        Console.Write("  > ");
    }
}