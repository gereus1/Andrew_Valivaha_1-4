using System;


namespace Lab_OP_2
{

    class Animal
    {
        public string Kind { get; }
        public string Name { get; }

        public Animal(string kind, string name)
        {
            Kind = kind;
            Name = name;
        }
        public override bool Equals(object obj)
        {
            if (obj is Animal animal) return Kind == animal.Kind && animal.Name == Name;
            else return false;
        }
        public override string ToString()
        {
            return $"Pet {Kind} {Name}";
        }
        public override int GetHashCode()
        {
            return (Kind, Name).GetHashCode();
        }

    }

    class Dog : Animal
    {
        public string Breed { get; }
        public Dog(string kind, string name, string breed) : base(kind, name)
        {
            Breed = breed;
        }
        public override bool Equals(object obj)
        {
            if (obj is Dog dog)

                return Breed == dog.Breed;
            return false;
        }
        public override string ToString()
        {
            return $"Dog {Breed}";
        }
        public override int GetHashCode()
        {
            return Breed.GetHashCode();
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("ruff");
        }

        public void Bite()
        {
            Console.WriteLine("ouuch!!!");
        }

        public void Jump()
        {
            Console.WriteLine("*Jumps*");
        }
    }

    class Puppy : Dog
    {
        public int Age { get; }
        public Puppy(int age, string kind, string name, string breed) : base(kind, name, breed)
        {
            Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Wooof");

        }
        public override bool Equals(object obj)
        {
            if (obj is Puppy puppy)

                return Name == puppy.Name && puppy.Age == Age;
            return false;
        }
        public override string ToString()
        {
            return $"Puppy {Age}\n {Name}\n {Kind}\n {Breed}\n";
        }
        public override int GetHashCode()
        {
            return (Name, Age).GetHashCode();
        }

        static void Main(string[] args)
        {
            var puppy = new Puppy(5, "Name: Joystick", "Kind : Sheepdog ", "Breed: Corgi");
            Console.WriteLine(puppy);
            puppy.MakeSound();
            puppy.Bite();
            puppy.Jump();
        }
    }
}





