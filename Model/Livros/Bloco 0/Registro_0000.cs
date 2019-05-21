using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Livros.Bloco_0
{
    class Registro_0000
    {
        public string Reg = "0000";
        public string Cod_ver { get; set; }
        public string Cod_fin { get; set; }
        public string Dt_ini { get; set; }
        public string Dt_fin { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string Uf { get; set; }
        public string Ie { get; set; }
        public string Cod_mun { get; set; }
        public string Im { get; set; }
        public string Suframa { get; set; }
        public string Ind_perfil { get; set; }
        public double Ind_ative { get; set; }

        public Registro_0000()
        {
        }

        public Registro_0000(string cod_ver, string cod_fin, string dt_ini, string dt_fin, string nome, string cnpj, string cpf, string uf, string ie, string cod_mun, string im, string suframa, string ind_perfil, double ind_ative)
        {
            Cod_ver = cod_ver;
            Cod_fin = cod_fin;
            Dt_ini = dt_ini;
            Dt_fin = dt_fin;
            Nome = nome;
            Cnpj = cnpj;
            Cpf = cpf;
            Uf = uf;
            Ie = ie;
            Cod_mun = cod_mun;
            Im = im;
            Suframa = suframa;
            Ind_perfil = ind_perfil;
            Ind_ative = ind_ative;
        }

        public override string ToString()
        {
            return string.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}",
                Reg,
                Cod_ver,
                Cod_fin,
                Dt_ini,
                Dt_fin,
                Nome,
                Cnpj,
                Cpf,
                Uf,
                Ie,
                Cod_mun,
                Im,
                Suframa,
                Ind_perfil,
                Ind_ative);
        }
    }
}
