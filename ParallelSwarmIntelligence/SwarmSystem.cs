using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSwarmIntelligence
{
    class SwarmSystem
    {
        int swarmNum;
        public SwarmSystem(int snum)
        {
            this.swarmNum = snum;
        }

        public int SwarmNum
        {
            get { return swarmNum; }
        }

        public List<Particle> pList = new List<Particle>();

        public double Px { get; set; }
        public double Py { get; set; }
        public double Gx { get; set; }
        public double Gy { get; set; }

        public void Intialize()
        {
            Random rd = new Random();
            for(int i=0;i<50;i++)   //50 particles in swarm
            {
                Particle p = new Particle();
                p.W = 0.73;
                p.C1 = 1.4;
                p.C2 = 1.5;
                p.Xx = rd.NextDouble() * 20;
                p.Xy = rd.NextDouble() * 20;
                double num = rd.NextDouble();
                if (num > 0.5)
                {
                    p.Xx = -1 * p.Xx;
                    p.Xy = -1 * p.Xy;
                }
                p.Vx = rd.NextDouble() * 5;
                p.Vy = rd.NextDouble() * 5;
                num = rd.NextDouble();
                if (num > 0.5)
                {
                    p.Vx = -1 * p.Vx;
                    p.Vy = -1 * p.Vy;
                }
                pList.Add(p);
            }
        }

        public double functionToSolve(double x, double y,string type)
        {
            double res = 0;
            //Rosenbrock function
            if(type=="Rosenbrock")
                res = (1 - x) * (1 - x) + 100 * (y - (x * x)) * (y - (x * x));

            //Himmelblau function
            if(type=="Himmelblau")
                res = (x * x + y - 11) * (x * x + y - 11) + (x + y * y - 7) * (x + y * y - 7);
            return res;
        }

        public SwarmResult doPSO(string type)  //Particle movement to achieve Particle Swarm Optimisation
        {
            Gx = pList[0].Xx;
            Gy = pList[0].Xy;
            for(int i = 0; i < 1000; i++)
            {
                //find best position in swarm
                Px = pList[0].Xx;
                Py = pList[0].Xy;
                foreach(Particle par in pList)
                {
                    if (Math.Abs(functionToSolve(par.Xx, par.Xy,type)) < Math.Abs(functionToSolve(Px, Py,type)))
                    {
                        Px = par.Xx;
                        Py = par.Xy;
                    }
                }

                if (Math.Abs(functionToSolve(Px, Py,type)) < Math.Abs(functionToSolve(Gx, Gy,type)))
                {
                    Gx = Px;
                    Gy = Py;
                }

                foreach(Particle par in pList)
                {
                    par.updateVelocity(Px, Py, Gx, Gy);
                    par.updatePosition();
                }
            }

            SwarmResult sres = new SwarmResult
            {
                SwarmId = swarmNum,
                X = Gx,
                Y = Gy,
                FunctionValue = functionToSolve(Gx, Gy,type)
            };
            return sres;
        }
    }
}
