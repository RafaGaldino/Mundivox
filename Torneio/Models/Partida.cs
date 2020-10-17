using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torneio.Models
{
    public class Partida
    {
        private int idPartida;
        private int eliminatoria;
        private List<Time> oponentes;
        private Time vencedor;

        public Partida(int idPartida, int eliminatoria, Time oponente1, Time oponente2)
        {
            IdPartida = idPartida;
            Eliminatoria = eliminatoria;
            Oponentes = new List<Time>
            {
                oponente1,
                oponente2
            };
        }

        public int IdPartida
        {
            get { return idPartida; }
            set { idPartida = value; }
        }
        public int Eliminatoria
        {
            get { return eliminatoria; }
            set { eliminatoria = value; }
        }
        public Time Vencedor
        {
            get { return vencedor; }
            set { vencedor = value; }
        }
        public List<Time> Oponentes
        {
            get { return oponentes; }
            set { oponentes = value; }
        }
    }
}
