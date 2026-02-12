using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Companion;
using GestaoCuidadores.Model;

namespace GestaoCuidadores.Services
{
    public class RelatorioCuidadores
    {
        public string GerarListaCuidadores(List<Cuidadores> listaCuidadores) 
        {
            QuestPDF.Settings.License = 
                QuestPDF.Infrastructure.LicenseType.Community;

            string caminho = Path.Combine(Path.GetTempPath(),
                $"RelatorioCuidador_{Guid.NewGuid()}.pdf");
            Document.Create(container => {

                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily(Fonts.Verdana));

                    page.Header()
                       .Text("Hello PDF!")
                       .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                });

            }).GeneratePdf(caminho);

            return caminho;
        }
    }
}
