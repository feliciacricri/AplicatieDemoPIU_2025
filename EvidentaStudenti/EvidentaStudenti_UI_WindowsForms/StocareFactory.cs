using NivelStocareDate;
using System.Configuration;
using System.IO;

namespace EvidentaStudenti_UI_WindowsForms
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareData GetAdministratorStocare()
        {
            string formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];

            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareStudenti_FisierBinar(caleCompletaFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareStudenti_FisierText(caleCompletaFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
