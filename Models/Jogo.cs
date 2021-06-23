using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiResultadosLoterias.Models
{
    /// <summary>
    /// Classe genérica para todos os jogos
    /// </summary>
    public class Jogo
    {
        protected string nomeJogo;
        protected string concurso;
        protected string dataConcurso;
        protected List<String> numeros;
        protected string valorAcumulado;
        private string time;

        public Jogo() { }

        public Jogo(string nomeJogo, string concurso, string dataConcurso, List<String> numeros, string valorAcumulado, string time)
        {
            this.nomeJogo = nomeJogo;
            this.concurso = concurso;
            this.dataConcurso = dataConcurso;
            this.numeros = numeros;
            this.valorAcumulado = valorAcumulado;
            this.time = time;
        }

        public string NomeJogo { get => nomeJogo; set => nomeJogo = value; }
        public string Concurso { get => concurso; set => concurso = value; }
        public string DataConcurso { get => dataConcurso; set => dataConcurso = value; }
        public List<string> Numeros { get => numeros; set => numeros = value; }
        public string ValorAcumulado { get => valorAcumulado; set => valorAcumulado = value; }
        public string Time { get => time; set => time = value; }
    }

}