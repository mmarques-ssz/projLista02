using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLista02
{
    class Pessoa
    {
        private string nome;
        private string sobrenome;
        private string sexo;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Pessoa(string nome, string sobrenome, string sexo = "F")
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.sexo = sexo;
        }

        public Pessoa()
            : this("", "")
        {
        }

        public string nomeCompleto()
        {
            return this.nome + " " + this.sobrenome;
        }

        public string nomeBibliografico()
        {
            return this.sobrenome.ToUpper() + ", " + this.nome;
        }
        
        public override string ToString()
        {
            return "Nome: " + this.nomeCompleto() + " - Sexo: " + (this.sexo == "F" ? "Feminino" : "Masculino");
        }
        
        public override bool Equals(object obj)
        {
            return this.nomeCompleto().Equals(((Pessoa)obj).nomeCompleto());
        }
    }
}
