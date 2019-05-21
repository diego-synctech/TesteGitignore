using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Livros.Bloco_0
{
    class Registro_0001
    {

        public string Reg = "0001";
        public double Ind_mov { get; set; }

        public Registro_0001() { }

        public Registro_0001(double ind_mov)
        {
            Ind_mov = ind_mov;
        }

        public override string ToString()
        {
            return
            string.Format("|{0}|{1}|",
                Reg,
                Ind_mov);
        }
    }
}
