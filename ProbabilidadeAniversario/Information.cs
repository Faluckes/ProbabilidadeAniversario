using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilidadeAniversario
{
    public class Information
    {
        public int Pessoas { get; set; }
        public double Aniversario
        {
            get
            {
                double p = Math.Pow((1.0 / 365), Pessoas);
                for (int i = (366 - Pessoas); i < 366; i++)
                {
                    p *= i;
                }

                int porcentagem = Convert.ToInt16((1 - p) * 100);
                return porcentagem;
            }
        }
        public Information(int pessoas)
        {
            Pessoas = pessoas;
        }


    }
}
