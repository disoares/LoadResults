using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiResultadosLoterias.Models
{
    public class Utils
    {

        /// <summary>
        /// Método responsável por verificar a URL que deverá ser utilizada
        /// </summary>
        /// <param name="jogo">Nome do concurso ao qual a URL deve buscar</param>
        /// <returns>Retorna a URL correta</returns>
        public static string GetUrl(string jogo)
        {
            string url = "";

            switch (jogo)
            {
                case "lotofacil":
                    url = "https://www.google.com/search?q=resultado+lotofacil&rlz=1C1SQJL_pt-BRBR922BR922&oq=resultado+lotofacil&aqs=chrome..69i57j0i131i433l2j0l2j0i131i433l3.4960j0j7&sourceid=chrome&ie=UTF-8";
                    break;
                case "mega-sena":
                    url = "https://www.google.com/search?rlz=1C1SQJL_pt-BRBR922BR922&sxsrf=ALeKk01QF3X7C5k4yevCqM7vMRx4M_rZeQ%3A1606423188831&ei=lBLAX9-fMrXP5OUP7rqJ6AY&q=resultado+mega-sena&oq=resultado+lotofacil&gs_lcp=CgZwc3ktYWIQARgBMgcIABBHELADMgcIABBHELADMgcIABBHELADMgcIABBHELADMgcIABBHELADMgcIABBHELADMgcIABBHELADMgcIABBHELADMgcIABCwAxBDMgcIABCwAxBDUABYAGDL8gJoAnACeACAAQCIAQCSAQCYAQCqAQdnd3Mtd2l6yAEKwAEB&sclient=psy-ab";
                    break;
                case "quina":
                    url = "https://www.google.com/search?rlz=1C1SQJL_pt-BRBR922BR922&sxsrf=ALeKk02K79ULJnVvxRl0Iz6XiFeSjaRqTw%3A1606423237082&ei=xRLAX93QBLe25OUP8LCcgA8&q=resultado+quina&oq=resultado+quina&gs_lcp=CgZwc3ktYWIQAzIICAAQsQMQgwEyCAgAELEDEIMBMgQIABADMggIABCxAxCDATIECAAQAzIECAAQAzICCAAyAggAMgQIABADMgIIADoHCCMQsAMQJzoHCAAQRxCwAzoHCAAQsAMQQ1CdgAJY8YMCYKOHAmgBcAJ4AIABnwKIAYsIkgEFMC4zLjKYAQCgAQGqAQdnd3Mtd2l6yAEKwAEB&sclient=psy-ab&ved=0ahUKEwidx57ziKHtAhU3G7kGHXAYB_AQ4dUDCA0&uact=5";
                    break;
                case "dupla-sena":
                    url = "https://www.google.com/search?rlz=1C1SQJL_pt-BRBR922BR922&sxsrf=ALeKk01TpAmpeuc757qojW7pUn3uAbulKg%3A1606423271596&ei=5xLAX-fuI-nF5OUP7qms4As&q=resultado+dupla+sena&oq=resultado+dul&gs_lcp=CgZwc3ktYWIQARgAMgQIABAKMgQIABAKMgQIABAKMgQIABAKMgQIABAKMgQIABAKMgQIABAKMgQIABAKMgQIABAKMgQIABAKOgcIABBHELADOgcIABCwAxBDOggIABCxAxCDAToCCAA6BQgAELEDOgQIABADUMztAljt8AJgqvoCaAJwAngAgAF2iAHSApIBAzAuM5gBAKABAaoBB2d3cy13aXrIAQrAAQE&sclient=psy-ab";
                    break;
                case "lotomania":
                    url = "https://www.google.com/search?rlz=1C1SQJL_pt-BRBR922BR922&sxsrf=ALeKk02Q1gQpeFEBuSQOyW4th229wDYiMA%3A1606423321000&ei=GBPAX4jFPMKP0AbEqpDgBA&q=resultado+lotomania&oq=resultado+lotomania&gs_lcp=CgZwc3ktYWIQAzICCAAyAggAMgUIABDLAToHCAAQRxCwAzoHCAAQsAMQQzoECCMQJzoKCAAQsQMQgwEQQzoICAAQsQMQgwE6BwgAELEDEEM6BAgAEEM6BQgAELEDOgQIABADUIbrAVjw8gFghPYBaAFwAngAgAF_iAHQB5IBAzEuOJgBAKABAaoBB2d3cy13aXrIAQrAAQE&sclient=psy-ab&ved=0ahUKEwiIsaCbiaHtAhXCB9QKHUQVBEwQ4dUDCA0&uact=5";
                    break;
                case "timemania":
                    url = "https://www.google.com/search?rlz=1C1SQJL_pt-BRBR922BR922&sxsrf=ALeKk00QjbSK-hJKzw2LqgxLdq0Pj62hMA%3A1606423353410&ei=ORPAX6a4GJ275OUP7uSOsAY&q=resultado+timemania&oq=resultado+timemania&gs_lcp=CgZwc3ktYWIQAzICCAAyAggAMgIIADICCAAyAggAOgcIABBHELADOgcIABCwAxBDOgUIABCxAzoICAAQsQMQgwE6BAgAEANQgtcBWILdAWDU3wFoAnACeACAAXuIAd8HkgEDMi43mAEAoAEBqgEHZ3dzLXdpesgBCsABAQ&sclient=psy-ab&ved=0ahUKEwjmuNqqiaHtAhWdHbkGHW6yA2YQ4dUDCA0&uact=5";
                    break;
                case "dia-de-sorte":
                    url = "https://www.google.com/search?rlz=1C1SQJL_pt-BRBR922BR922&sxsrf=ALeKk00QjbSK-hJKzw2LqgxLdq0Pj62hMA%3A1606423353410&ei=ORPAX6a4GJ275OUP7uSOsAY&q=resultado+timemania&oq=resultado+timemania&gs_lcp=CgZwc3ktYWIQAzICCAAyAggAMgIIADICCAAyAggAOgcIABBHELADOgcIABCwAxBDOgUIABCxAzoICAAQsQMQgwE6BAgAEANQgtcBWILdAWDU3wFoAnACeACAAXuIAd8HkgEDMi43mAEAoAEBqgEHZ3dzLXdpesgBCsABAQ&sclient=psy-ab&ved=0ahUKEwjmuNqqiaHtAhWdHbkGHW6yA2YQ4dUDCA0&uact=5";
                    break;
            }

            return url;
        }

        public static string[] getGames()
        {
            string[] games = new string[] { "lotofacil", "mega-sena", "quina", "dupla-sena", "lotomania", "timemania", "dia-de-sorte"};
            return games;
        }

    }
}