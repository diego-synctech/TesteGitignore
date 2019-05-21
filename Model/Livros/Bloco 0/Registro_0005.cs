using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Livros.Bloco_0
{
    class Registro_0005
    {

        public string Reg = "0005";
        public string Fantasia { get; set; }
        public string Cep { get; set; }
        public string End { get; set; }
        public string Num { get; set; }
        public string Compl { get; set; }
        public string Bairro { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public Registro_0005() { }

        public Registro_0005(string fantasia, string cep, string end, string num, string compl,
                            string bairro, string fone, string fax, string email)
        {
            Fantasia = fantasia;
            Cep = cep;
            End = end;
            Num = num;
            Compl = compl;
            Bairro = bairro;
            Fone = fone;
            Fax = fax;
            Email = email;
        }

        public override string ToString()
        {
            return
            string.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|",
                Reg,
                Fantasia,
                Cep,
                End,
                Num,
                Compl,
                Bairro,
                Fone,
                Fax,
                Email);
        }
    }
}
