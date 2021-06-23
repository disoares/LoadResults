using ApiResultadosLoterias.Models;
using LoadResults.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadResults
{
    public partial class LoadResults : Form
    {

        private string currentGame = "";

        public LoadResults()
        {
            InitializeComponent();

            // Chama a ação
            bgWorker.RunWorkerAsync();

        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Pega os nomes dos jogos
            var games = Utils.getGames();

            // Variáveis de controle
            int count = 0;
            int totalCount = games.Length;
            float perc = 0;

            for (int i = 0; i < games.Length; i++)
            {

                // Incrementa o contador
                count++;

                // Calcula o percentual
                perc = ((float)count / (float)totalCount) * 100f;

                // Define o nome do jogo atual
                currentGame = games[i];

                var path = Directory.GetCurrentDirectory() + "\\JSON\\";

                // Gera a pasta de jsons, em caso de não existir
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                WebScrapingModel wsm = new WebScrapingModel();
                var jogo = wsm.AcessaResultados(games[i], Utils.GetUrl(games[i]));

                string json = JsonConvert.SerializeObject(jogo);
                Console.WriteLine(json);

                GenerateJson.WriteJson(path, games[i], json);

                // Altera a porcentagem
                bgWorker.ReportProgress((int)perc);

            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Thread.Sleep(100);
            label.Text = "Estamos processando os resultados de " + currentGame;
            this.Text = "Processamento em andamento: " + e.ProgressPercentage + " % ";            
            progress.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Application.Exit();
        }
    }
}
