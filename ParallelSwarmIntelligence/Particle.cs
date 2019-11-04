using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSwarmIntelligence
{
    class Particle
    {
        public double W { get; set; }   //inertia weight
        public double C1 { get; set; }  //cognitive weight - constant
        public double C2 { get; set; }

        Random rd = new Random();
        //we are considering a 2D problem. 
        //So, velocity and position would have 2 components in each x and y.
        public double Xx { get; set; }  //position in x
        public double Xy { get; set; }  //position in y

        public double Vx { get; set; } //velocity in x
        public double Vy { get; set; }  //velocity in y

        public void updateVelocity(double Px, double Py, double Gx, double Gy)
        {
            // P is current best position of any particle in the swarm.
            //G is global best position so far.
            Vx = W * Vx + C1 * rd.NextDouble() * (Px - Xx) + C2 * rd.NextDouble() * (Gx - Xx);
            if (Vx > 5)
                Vx = 5;
            if (Vx < -5)
                Vx = -5;
            Vy = W * Vy + C1 * rd.NextDouble() + (Py - Xy) + C2 * rd.NextDouble() * (Gy - Xy);
            if (Vy > 5)
                Vy = 5;
            if (Vy < -5)
                Vy = -5;
        }

        public void updatePosition()
        {
            Xx = Xx + Vx;
            //put some bound on position
            if (Xx > 20)
                Xx = 20;
            if (Xx < -20)
                Xx = -20;

            Xy = Xy + Vy;
            if (Xy > 20)
                Xy = 20;
            if (Xy < -20)
                Xy = -20;
        }



    }
}
