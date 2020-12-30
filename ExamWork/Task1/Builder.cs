using System;
using System.Collections.Generic;
using System.Text;

namespace ExamWork.Task1
{
    //Я сделал через Builder так как не вижу никакой другой альтернативы
    //При увеличений количества ингридиентов мы будем влезать в пользовательский код
    //Не хватило фантазий :( что бы придумать что либо лучше
   
    class BavarianDumpling : DumplingsBuilder
    {
        public override void AddDough()
        {
            Console.WriteLine("Dough added");
        }

        public override void AddMeat()
        {
            Console.WriteLine("Meat added");
        }

        public override void AddSalt()
        {
            Console.WriteLine("Salt added");
        }

        public override void AddSpices()
        {
            Console.WriteLine("Spices added");
        }
    }

    class StudentDumpling : DumplingsBuilder
    {
        public override void AddDough()
        {
            Console.WriteLine("Dough added");
        }

        public override void AddMeat()
        {
            Console.WriteLine("Meat added");
        }

        public override void AddSalt()
        {
            Console.WriteLine("Salt added");
        }

        public override void AddSpices()
        {
            Console.WriteLine("Spices added");
        }
    }

    class MerchantsDumpling : DumplingsBuilder
    {
        public override void AddDough()
        {
            Console.WriteLine("Dough added");
        }

        public override void AddMeat()
        {
            Console.WriteLine("Meat added");
        }

        public override void AddSalt()
        {
            Console.WriteLine("Salt added");
        }

        public override void AddSpices()
        {
            Console.WriteLine("Spices added");
        }
    }

    class Cook
    {
        public Dumpling CookDumping(DumplingsBuilder builder)
        {
            builder.AddDough();
            builder.AddMeat();
            builder.AddSalt();
            builder.AddSpices();

            return builder.dumpling;
        }
    }

    abstract class DumplingsBuilder
    {
        public Dumpling dumpling { get; set; }
        public void MakeDumplings()
        {
            dumpling = new Dumpling();
        }
        public abstract void AddMeat();
        public abstract void AddDough();
        public abstract void AddSalt();
        public abstract void AddSpices();
    }

    class Dumpling
    {
        public Meat meat { get; set; }
        public Dough dough { get; set; }
        public Salt salt { get; set; }
        public Spices spices { get; set; }
    }

    class Meat
    {
        public string Name { get; set; }
    }

    class Dough
    {
        public string Name { get; set; }
    }

    class Salt
    {
        public string Name { get; set; }
    }

    class Spices
    {
        public string Name { get; set; }
    }
}
