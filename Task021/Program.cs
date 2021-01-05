using System;

namespace Task021
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink mojito = new Drink();
            mojito.setName = "Mojito";
            mojito.setDescription = "This is a really good drink!";
            mojito.setIngredients = new string[] { "vodka", "ice", "lime", "Sprite" };
            mojito.display();
            Console.ReadLine();
        }
    }
    class Drink
    {
        private string name;
        private string description;
        private string[] ingredients;
        
        public string setName
        {
            get { return name; }
            set { name = value; }
        }

        public string setDescription
        {
            get { return description; }
            set { description = value; }
        }

        public string[] setIngredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public void display()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("description: " + description);
            Console.Write("ingredients: ");
            for( int i = 0; i <= ingredients.Length - 1; i++)
            {   
                if (i < ingredients.Length - 1)
                {
                    Console.Write(ingredients[i] + ", ");
                }
                
                if (i == ingredients.Length - 1)
                {
                    Console.Write(ingredients[i] + ".");
                    Console.Write("\n");
                } 
            }
        }
    }
}
