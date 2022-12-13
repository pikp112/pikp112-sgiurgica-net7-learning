namespace Week4_HomeWork
{
    public class Animal
    {
        public string name;
        public string species;
        public string breed;
        public int age;
        public string color;
        public double weight;
        public bool isSpayedOrNeutered;
        
        public Animal(string name, string species, string breed, int age, string color, double weight, bool isSpayedOrNeutered)
        {
            this.name = name;
            this.species = species;
            this.breed = breed;
            this.age = age;
            this.color = color;
            this.weight = weight;
            this.isSpayedOrNeutered=isSpayedOrNeutered;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSpecies()
        {
            return species;
        }

        public string GetBreed()
        {
            return breed;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetColor()
        {
            return color;
        }
        public double GetWeight()
        {
            return weight;
        }

        public bool IsSpayedOrNeutered()
        {
            if (this.isSpayedOrNeutered == true)
            {
                return true;
            } 
            else  return false;
      
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSpecies(string species)
        {
            this.species = species;
        }

        public void SetBreed(string breed)
        {
            this.breed = breed;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }

        public void SetIsSpayedOrNeutered(bool isSpayedOrNeutered)
        {
            this.isSpayedOrNeutered=isSpayedOrNeutered;
        }
    }
}
