using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torneio.Models
{
    public class Time
    {
        private int idTime;
        private string nome;

        public Time(int idTime, string nome)
        {
            IdTime = idTime;
            Nome = nome;
        }
        public int IdTime
        {
            get { return idTime; }
            set { idTime = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
