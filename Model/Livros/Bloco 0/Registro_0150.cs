using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Livros.Bloco_0
{
    class Registro_0150
    {

        public string Reg = "0150";
        public string Cod_part { get; set; }
        public string Nome { get; set; }
        public double Cod_pais { get; set; }
        public double Cnpj { get; set; }
        public double Cpf { get; set; }
        public string Ie { get; set; }
        public double Cod_mun { get; set; }
        public string Suframa { get; set; }
        public string End { get; set; }
        public string Num { get; set; }
        public string Compl { get; set; }
        public string Bairro { get; set; }

        public Registro_0150() { }

        public Registro_0150(string cod_part, string nome, double cod_pais, double cnpj, double cpf, string ie,
            double cod_mun, string suframa, string end, string num, string compl, string bairro)
        {
            Cod_part = cod_part;
            Nome = nome;
            Cod_pais = cod_pais;
            Cnpj = cnpj;
            Cpf = cpf;
            Ie = ie;
            Cod_mun = cod_mun;
            Suframa = suframa;
            End = end;
            Num = num;
            Compl = compl;
            Bairro = bairro;
        }

        public override string ToString()
        {
            return
            string.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|",
                Reg,
                Cod_part,
                Nome,
                Cod_pais,
                Cnpj,
                Cpf,
                Ie,
                Cod_mun,
                Suframa,
                End,
                Num,
                Compl,
                Bairro);
        }
    }
}
