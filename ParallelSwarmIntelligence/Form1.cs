using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelSwarmIntelligence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_parallel_swarm_Click(object sender, EventArgs e)
        {
            int numSwarmsToLaunch = 10;
            Task<SwarmResult>[] taskArr = new Task<SwarmResult>[numSwarmsToLaunch];
            for(int i = 0; i < taskArr.Length; i++)
            {
                taskArr[i] = Task.Factory.StartNew<SwarmResult>(
                    (obj) =>
                    {
                        SwarmSystem ss = new SwarmSystem((int)obj);
                        ss.Intialize();
                        SwarmResult sr = ss.doPSO("Rosenbrock");
                        return sr;
                    }, i);
            }

            List<SwarmResult> rList = new List<SwarmResult>();
            Task tskFinal = Task.Factory.ContinueWhenAll(taskArr,
                (tsks) =>
                {
                    Console.Write(tsks.Length.ToString() + " tasks");
                    for (int i = 0; i < tsks.Length; i++)
                        rList.Add(tsks[i].Result);
                }
                );
            tskFinal.Wait();
            rList.Sort();
            dataGridView1.DataSource = rList;
            dataGridView1.Refresh();
            label1.Text = rList[0].ToString();
        }

        private void btn_seq_swarm_Click(object sender, EventArgs e)
        {
            SwarmSystem ss = new SwarmSystem(0);
            ss.Intialize();
            SwarmResult sr = ss.doPSO("Rosenbrock");
            label1.Text = sr.ToString();
        }

        private void btn_himmelblau_parallel_Click(object sender, EventArgs e)
        {
            int numSwarmsToLaunch = 10;
            Task<SwarmResult>[] taskArr = new Task<SwarmResult>[numSwarmsToLaunch];
            for (int i = 0; i < taskArr.Length; i++)
            {
                taskArr[i] = Task.Factory.StartNew<SwarmResult>(
                    (obj) =>
                    {
                        SwarmSystem ss = new SwarmSystem((int)obj);
                        ss.Intialize();
                        SwarmResult sr = ss.doPSO("Himmelblau");
                        return sr;
                    }, i);
            }

            List<SwarmResult> rList = new List<SwarmResult>();
            Task tskFinal = Task.Factory.ContinueWhenAll(taskArr,
                (tsks) =>
                {
                    Console.Write(tsks.Length.ToString() + " tasks");
                    for (int i = 0; i < tsks.Length; i++)
                        rList.Add(tsks[i].Result);
                }
                );
            tskFinal.Wait();
            rList.Sort();
            dataGridView1.DataSource = rList;
            dataGridView1.Refresh();
            label1.Text = rList[0].ToString();
        }
    }
}
