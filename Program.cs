class Program
{
    static void Main()
    {
        string[] IngredientsBread = new string[] { "Water", "Flour","Yeast" };
        string[] IngredientsCake = new string[] { "Sugar", "Flour" , "Egg","Milk","Baking Powder","Vanilin"};

        Food Ekmek = new("Bread", IngredientsBread, 7);
        Food Pasta = new("Cake", IngredientsCake, 50);
        Food Poaca = new("Pogacha", IngredientsBread, 10);
        List<Food> foods = new()
        {
            Ekmek,
            Pasta
        };
        Bakery arslan = new("Arslan", foods, 4);
        arslan.NamedFood(Poaca);
        arslan.ShowMenu();
    }
}

class Bakery
{
    public string Name { get; set; }//Fırın Nameı
    public List<Food> Foods { get; set; }//Food sınıfından liste olusturuyorum menu olusturmak için 
    public int OpeningTime { get; set; }//Açılış saati

    public Bakery(string Name, List<Food> Foods, int OpeningTime)//Constructorla fırının genel bilgilerini alıyorum
    {
        this.Name = Name;
        this.Foods = Foods;
        this.OpeningTime = OpeningTime;
    }

    public void NamedFood(Food food)//Food sınıfından değişken alıyor
    {
        if (!Foods.Contains(food))//Listenin içinde bu yemek var mı kontrol ediyor
        {
            Foods.Add(food);//yoksa ekle
        }
    }

    public void ShowMenu()//Menu bilgilerini göster
    {
        Console.WriteLine($"Bakery: {Name}");
        Console.WriteLine($"Opening time: {OpeningTime}");

        foreach (var food in Foods)
        {
            Console.WriteLine($"Food: {food.Name}");
            Console.WriteLine($"Ingredients: {string.Join(", ", food.Ingredients)}");
            Console.WriteLine($"Price: {food.Price}");
            Console.WriteLine();
        }
    }
}

class Food//Yemekle ilgili genel bilgiler
{
    public string Name { get; set; }//Yemegin Nameı
    public string[] Ingredients { get; set; }//Malzemeleri dizi içinde tutuyorum
    public int Price { get; set; }//Fiyatı tutuyorum

    public Food(string Name, string[] Ingredients, int Price)//Constructorla yemekle ilgili bilgileri alıyorum
    {
        this.Name = Name;
        this.Ingredients = Ingredients;
        this.Price = Price;
    }
}
