using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet
{
    public partial class Pet
    {

        public int Activity { get; set; }
        // int Comfort { get; set; }
       // public int Hunger { get; set; }
        public int Health { get; set; }
        public int Mood { get; set; }  //настроение     
        public int Satiety { get; set; } //сытость
      //  public int Thirst { get; set; } //жажда

        public Pet()
        {
            Activity = 10;
            Health = 10;
            Mood = 10;
            Satiety = 10;
        }

    }
}
