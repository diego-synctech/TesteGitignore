using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Livros.Bloco_0
{
    class Registro_0015
    {

        public string Reg = "0015";
        public string Uf_st { get; set; }
        public string Ie_st { get; set; }

        public Registro_0015() { }

        public Registro_0015(string uf_st, string ie_st)
        {
            Uf_st = uf_st;
            Ie_st = ie_st;
        }

        public override string ToString()
        {
            return
            string.Format("|{0}|{1}|{2}|",
                Reg,
                Uf_st,
                Ie_st);
        }
    }
}
