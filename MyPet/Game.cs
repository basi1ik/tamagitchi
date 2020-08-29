using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Timers;
using System.Transactions;

namespace MyPet
{
    public class Game
    {
        StateBody StateBody = StateBody.Dead;
        private Pet _pet;
        double a, h, m, s;
        private Timer timer = new Timer();

        public void Start()
        {
            _pet = new Pet();
            StateBody = StateBody.Alive;
            
            timer.Interval = 1000;
            timer.Elapsed += ReduceLivingParameters;
            timer.Enabled = true;                                  

        }

        private void ReduceLivingParameters(object sender, ElapsedEventArgs e)
        {
            if (_pet.Health > 0)
            {
                Console.Write(_pet.Activity--);
                Console.Write(_pet.Health--);
                Console.Write(_pet.Mood--);
                Console.Write(_pet.Satiety--);
            }
            else
            {
                timer.Enabled = false;
                Console.Write("It dead");
            }

            Console.WriteLine();
           
        }       

        public void Play()
        {

        }

        public void Feed()
        {

        }

        public void PutToSleep()
        {

        }

    }
}
