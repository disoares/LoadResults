using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiResultadosLoterias.Models
{
    public class WebScrapingModel
    {

        /// <summary>
        /// Método responsável por buscar os resultados de modo genérico
        /// </summary>
        /// <param name="nomeJogo">Nome do concurso</param>
        /// <param name="url">URL a ser utilizada na busca</param>
        /// <returns>Retorna um objeto com todas informações de resultado</returns>
        public List<Jogo> AcessaResultados(string nomeJogo, string url)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
            List<Jogo> dadosJogo = new List<Jogo>();

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("user-data-dir=" + path + "ChromeDriver\\Cache");
            options.AddArgument("--headless");

            using (ChromeDriver driver = new ChromeDriver(path, options))
            {

                // Navega até a URL solicitada
                driver.Navigate().GoToUrl(url);

                // Separa data e número do concurso
                string[] arrConcData = driver.FindElementByClassName("qLLird").Text.ToString().Split('(');

                var concurso = arrConcData[0].Trim();
                var dataConcurso = "(" + arrConcData[1];

                // Coloca os números num array
                List<IWebElement> tabElementsNumbers;
                if (!nomeJogo.Equals("timemania"))
                    tabElementsNumbers = driver.FindElements(By.ClassName("UHlKbe")).ToList();
                else
                    tabElementsNumbers = driver.FindElements(By.ClassName("ZVkP3")).ToList();

                // Coloca o valor acumulado e o time em uma string
                List<IWebElement> tabElementsValor = driver.FindElements(By.ClassName("br1ue")).ToList();

                // percorre os números
                List<String> numeros = new List<string>();
                foreach (IWebElement elemento in tabElementsNumbers)
                {
                    numeros.Add(elemento.Text);
                }

                // Percorre as informações finais
                List<String> infos = new List<string>();
                foreach (IWebElement elemento in tabElementsValor)
                {
                    infos.Add(elemento.Text);
                }

                if (!nomeJogo.Equals("timemania"))
                {
                    // Adiciona os resultados em um Array
                    dadosJogo.Add(new Jogo()
                    {
                        NomeJogo = nomeJogo,
                        Concurso = concurso,
                        DataConcurso = dataConcurso,
                        Numeros = numeros,
                        ValorAcumulado = infos[0]
                    });
                }
                else
                {
                    // Adiciona os resultados em um Array
                    dadosJogo.Add(new Jogo()
                    {
                        NomeJogo = nomeJogo,
                        Concurso = concurso,
                        DataConcurso = dataConcurso,
                        Numeros = numeros,
                        ValorAcumulado = infos[1],
                        Time = infos[0]
                    });
                }

            }

            return dadosJogo;
        }

    }
}