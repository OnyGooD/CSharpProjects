namespace dogauml
{

    abstract class Food
    {
        protected string name;
    }

    class Meat : Food
    {
        public Meat(string name)
        {
            this.name = name;
        }
    }

    class Plant : Food
    {
        public Plant(string name)
        {
            this.name = name;
        }
    }

    abstract class Animal
    {
        protected string name;
        protected List<Food> feeder = new List<Food>();
        protected bool hungry;
        protected bool canFly;

        public void eat()
        {

            if(feeder.Count > 0) 
            {
                foreach (Food food in feeder)
                {
                    feeder.RemoveAt(1);
                    Console.WriteLine($"A {this.name} eszik");
                    this.hungry = false;
                }
            }
            else
            {
                Console.WriteLine("Nincs elég étel");
            }
            
        }

        public void sleep()
        {
            Console.WriteLine("Zzzzz");
            this.hungry = true;
        }
    }

    abstract class Herbivorous : Animal
    {
        public void searchFood()
        {

            Console.WriteLine($"{this.name} ételt keres.");
            Random rnd = new Random();

            if (rnd.Next(0, 100) < 70)
            {
                Plant plant = new Plant("Növény");
                Console.WriteLine("Ételt talált");
                feeder.Add(plant);
            }
            else
            {
                Console.WriteLine("Nem talált ételt");
            }
        }

        public void feed(Plant food)
        {
            feeder.Add(food);
        }
    }

    class Deer : Herbivorous
    {
        public Deer(string name)
        {
            this.name = name;
        }
    }

    abstract class Predator : Animal
    {
        public void goHunt()
        {
            Console.WriteLine($"A {this.name} vadászni indul");
            Random rnd = new Random();

            if(rnd.Next(0, 100) < 40)
            {
                Meat meat = new Meat("Hús");
                Console.WriteLine("Elejtette a példáját");
                feeder.Add(meat);
                
            }
            else
            {
                Console.WriteLine("Nem talált prédát");
            }
        }

        public void feed(Meat food)
        {
            feeder.Add(food);
        }
    }

    class Wolf : Predator
    {
        public Wolf(string name)
        {
            this.name = name;
        }
    }

    class Eagle : Predator
    {
        public Eagle(string name)
        {
            this.name = name;
        }

        public void fly()
        {
            Console.WriteLine($"A {this.name} magasra száll.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tomo dolgozata");
        }
    }
}
