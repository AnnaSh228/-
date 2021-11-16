using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace фрукти
{
    public class Animals
    {
        public static Random rnd = new Random();
        public virtual String GetInfo()
        {

            return "Животное";
        }
    }
    public class Cows : Animals
    {
        public int LengthOfHorns = 0;
        public int MilkPerDay = 0;


        public override String GetInfo()
        {
            var str = "Корова";
            str += String.Format("\nДлина рога: {0}", this.LengthOfHorns);
            str += String.Format("\nКоличество молока в день: {0}", this.MilkPerDay);
            return str;
        }
        public static Cows Generate()
        {
            var rnd = new Random();
            return new Cows
            {
                LengthOfHorns = rnd.Next() % 100, 
                MilkPerDay = rnd.Next() % 100, 
                
            };
        }
    public enum DogsBreed { poodle,shepherd,dachshund,husky,chihuahua };


    public class Dogs : Animals
    {
        public DogsBreed type = DogsBreed.poodle;
        public int IgnoreDistance = 0;
        public int LengthOfTail = 0;

        public override String GetInfo()
        {
            var str = "Собака";
            str += String.Format("\nПорода: {0}", this.Breed);
            str += String.Format("\nДистанция игнорирования: {0}", this.IgnoreDistance);
            str += String.Format("\nДлина хвоста: {0}", this.LengthOfTail);

            return str;
        }
    }
    public class Cats : Animals
    {
        public bool Wool = false;
        public int CatchOfMice = 0;


        public override String GetInfo()
        {
            var str = "Кошка";
            str += String.Format("\nШерсть: {0}", this.Wool);
            str += String.Format("\nУлов мышей в день: {0}", this.CatchOfMice);
            return str;
        }
    }
}