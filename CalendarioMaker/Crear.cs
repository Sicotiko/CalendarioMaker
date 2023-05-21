using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.Conversion;
using ceTe.DynamicPDF.HtmlConverter;

namespace CalendarioMaker
{
    public class Crear
    {
        public static async Task Calendario(string HtmlText)
        {
            ceTe.DynamicPDF.HtmlConverter.ConversionOptions Options = new ceTe.DynamicPDF.HtmlConverter.ConversionOptions(ceTe.DynamicPDF.HtmlConverter.PageSize.Letter, ceTe.DynamicPDF.HtmlConverter.PageOrientation.Portrait);

            string outPath = $"{Application.StartupPath}\\Calendario.pdf";

            await ceTe.DynamicPDF.HtmlConverter.Converter.ConvertAsync(HtmlText, outputPath: outPath, conversionOptions: Options);
        }
        public static async Task OtroCalendario(string HtmlText)
        {
            ceTe.DynamicPDF.Conversion.HtmlConversionOptions options = new HtmlConversionOptions(false);
            HtmlConverter converter = new HtmlConverter(HtmlText, options);
            string outPath = $"{Application.StartupPath}\\Calendario.pdf";

            await converter.ConvertAsync(outPath);
        }
        public static async Task OtroCalendarioMas(float medidaAncho, float medidaAlto)
        {
            await Task.Run(() =>
            {
                Document document = new Document();
                Page page = new Page();
                document.Pages.Add(page);

                float margenIzquierdo = 25f;
                float margenSuperior = 25f;
                //float medidaAncho = 100f;
                //float medidaAlto = 200f;

                //Cuadro superior Izquierdo
                page.Elements.Add(new ceTe.DynamicPDF.PageElements.Rectangle(margenIzquierdo, margenSuperior, medidaAncho, medidaAlto, 1));
                //Cuadro superior Derecho
                page.Elements.Add(new ceTe.DynamicPDF.PageElements.Rectangle(margenIzquierdo + medidaAncho, margenSuperior, medidaAncho, medidaAlto, 1));
                //Cuadro inferior Izquierdo
                page.Elements.Add(new ceTe.DynamicPDF.PageElements.Rectangle(margenIzquierdo, margenSuperior + medidaAlto, medidaAncho, medidaAlto, 1));
                //Cuadro inferior Derecho
                page.Elements.Add(new ceTe.DynamicPDF.PageElements.Rectangle(margenIzquierdo + medidaAncho, margenSuperior + medidaAlto, medidaAncho, medidaAlto, 1));

                string outPath = $"{Application.StartupPath}\\Calendario.pdf";
                document.Draw(outPath);
            });

        }
    }

}
