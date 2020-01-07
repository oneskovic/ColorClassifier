﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorClassifierShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<double> coefficients = new List<double>(new double[] { 0.194489, 0.166827, -0.0630532, 0.501895, 0.181344, 0.264408, -0.127565, -0.109208, -0.026933, -0.0360157, 0.00175491, -0.0448314, -0.000224631, 0.0143994, 0.285368, 0.0933684, -0.262434, -0.0103089, 0.105413, 0.201726, -0.054004, -0.382514, -0.207973, -0.00212605, -0.00793067, -0.097735, -0.197776, -0.0986734, 0.296751, -0.00155308, 0.33634, 0.306369, 0.0634346, -0.104239, 0.0422723, -0.300373, 0.0789672, 0.23232, -0.400129, -0.233948, -0.575312, 0.0611903, 0.18536, -0.244787, 0.220348, 0.105602, 0.152187, -0.24238, -0.134792, 0.15957, -0.366493, -0.218462, 0.251473, -0.217001, 0.00130905, 0.0762154, 0.0246502, 0.173805, 0.211167, -0.0862961, 0.0578047, 0.109628, -0.000735803, -0.143641, 0.0698838, 0.150945, 0.149171, -0.171157, -0.0337775, -0.338349, 0.39611, -0.290934, -0.118927, 0.245056, 0.131793, 0.0665719, -0.131525, 0.0864925, -0.0379249, -0.330471, -0.0600767, -0.232973, 0.0835982, 0.132991, 0.10393, -0.193163, -0.143387, -0.231897, -0.12743, -0.166195, 0.363469, -0.0647806, 0.170632, -0.0438925, -0.266393, 0.055194, 0.110892, -0.0108075, -0.170988, 0.1862, 0.0617143, 0.207, 0.170252, -0.0120169, 0.309602, 0.0785233, -0.290969, -0.377832, -0.30848, 0.0919976, -0.0379899, -0.19723, -0.0289484, 0.252266, 0.333462, 0.181587, -0.135888, -0.10731, 0.374198, 0.225258, 0.14235, -0.146357, 0.223988, -0.429695, 0.287121, 0.247556, -0.368597, -0.326756, -0.129036, 0.154243, 0.00796966, 0.0736577, 0.201197, 0.183354, -0.224381, -0.222656, -0.246465, 0.128219, -0.0353628, -0.385099, 0.32468, -0.0158921, 0.125636, 0.226851, 0.0962891, 0.13647, 0.0909499, -0.0624893, 0.0309879, 0.0671813, -0.176352, -0.158988, -0.0472788, 0.0163381, -0.0809128, 0.34784, -0.144418, 0.220267, -0.0466044, 0.119002, -0.084049, 0.0458064, 0.123224, -0.0419893, -0.228243, 0.017897, -0.20544, 0.573887, -0.0176014, -0.1676, 0.118469, 0.0966095, -0.26037, 0.101788, 0.163997, 0.337792, -0.129552, -0.0598962, -0.17725, 0.187482, -0.157574, -0.344994, 0.0857019, 0.12439, 0.172661, -0.195188, -0.409891, 0.139324, -0.0624386, 0.220206, 0.0700826, 0.226294, -0.306888, 0.272845, -0.289845, -0.146248, 0.249088, -0.0204525, 0.143498, -0.0626602, -0.204811, -0.11417, -0.300297, -0.0851538, -0.0859354, -0.532445, 0.436995, 0.212621, -0.434415, -0.230542, -0.097256, 0.174767, -0.0782253, 0.384514, 0.149017, -0.278677, -0.354284, 0.0509501, 0.198733, -0.185927, -0.514967, -0.225798, 0.0162333, -0.0225744, -0.236561, -0.0706064, 0.0770575, -0.0723307, -0.289128, 0.0233431, -0.365337, -0.154725, -0.294992, 0.121315, 0.0386356, 0.347648, -0.0685645, -0.115128, -0.0158374, 0.176683, -0.0728322, 0.161517, -0.319319, -0.296814, 0.0635622, -0.18735, -0.0286723, -0.0471457, -0.585513, 0.065906, -0.132862, 0.054975, -0.0444832, -0.211447, -0.221765, -0.294157, 0.0992464, -0.358084, -0.139622, 0.165994, -0.19853, -0.0499027, -0.0642298, 0.240376, 0.455063, -0.102383, -0.17707, -0.527099, -0.0993192, -0.561323, -0.169809, -0.146392, -0.246549, 0.300139, 0.0998755, -0.450813, -0.138514, 0.167827, -0.206057, -0.441721, -0.0322773, -0.426899, -0.212458, -0.719137, -0.436706, 0.334835 });

        static List<double> coefs;
        static int R, G, B;
        static int coef_index;
        static readonly int max_degree = 10;
        static double SumAllOfDegree(int degree)
        {
            double sum = 0;
            for (int r = 0; r <= degree; r++)
            {
                for (int g = 0; g <= (degree - r); g++)
                {
                    int b = degree - (r + g);
                    sum += Math.Pow(R, r) * Math.Pow(G, g) * Math.Pow(B, b) * coefs[coef_index++];
                }
            }
            return sum;
        }

        static double EvalFunction()
        {
            coef_index = 0;
            coefs = coefficients;
            double result_sum = 0;
            for (int degree = 0; degree <= max_degree; degree++)
                result_sum += SumAllOfDegree(degree);
            return result_sum;
        }
        static double ApproxSigmoid(double value)
        {
            return value / (1 + Math.Abs(value));
        }

        static void UpdateDecision()
        {
            var label = ActiveForm.Controls.Find("lb_decision", true)[0] as Label;
            double decision = ApproxSigmoid(EvalFunction());
            if (decision >= 0.5)
                label.Text = "RED";
            else
                label.Text = "NOT RED";

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lb_red.Text = tb_red.Value.ToString();
            R = tb_red.Value;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
            UpdateDecision();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lb_green.Text = tb_green.Value.ToString();
            G = tb_green.Value;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
            UpdateDecision();
        }

        private void tb_blue_Scroll(object sender, EventArgs e)
        {
            lb_blue.Text = tb_blue.Value.ToString();
            B = tb_blue.Value;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
            UpdateDecision();
        }
    }
}