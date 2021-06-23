using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadResults.Models
{
    class GenerateJson
    {

        /// <summary>
        /// Método responsável por gerar os arquivos JSON
        /// </summary>
        /// <param name="path">Diretório onde o arquivo será salvo</param>
        /// <param name="game">Nome do jogo</param>
        /// <param name="json">Valores do json</param>
        public static void WriteJson(string path, string game, string json)
        {
            using (var file = new StreamWriter(path + game + ".json"))
            {
                file.WriteLine(json);
            }
        }

    }
}
