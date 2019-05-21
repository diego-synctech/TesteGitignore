using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Livros.Bloco_1
{
    class Registro_1105
    {
        public string Reg = "1105";
        public string Cod_mod { get; set; }
        public string Serie { get; set; }
        public double Num_doc { get; set; }
        public double Chv_nfe { get; set; }
        public string Dt_doc { get; set; }
        public string Cod_item { get; set; }


        public Registro_1105() { }
        public Registro_1105(string cod_mod, string serie, double num_doc, double chv_nfe, string dt_doc, string cod_item)
        {
            Cod_mod = cod_item;
            Serie = serie;
            Num_doc = num_doc;
            Chv_nfe = chv_nfe;
            Dt_doc = dt_doc;
            Cod_item = cod_item;

        }
        public override string ToString()
        {
            return
            String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|",
            Reg,
            Cod_mod,
            Serie,
            Num_doc,
            Chv_nfe,
            Dt_doc,
            Cod_item);

        }
    }
}
