using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioMaker
{
    public class HtmlText
    {
        public static string GetHmltText(string PathImg,float TituloX,float TituloY, Color TituloColor,Color TituloSombraColor)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html lang=\"en\">");
            sb.AppendLine("<head>");
            sb.AppendLine("    <meta charset=\"UTF-8\">");
            sb.AppendLine("    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
            sb.AppendLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            sb.AppendLine("    <title>Document</title>");
            sb.AppendLine("    <style>");
            sb.AppendLine("        body");
            sb.AppendLine("{");
            sb.AppendLine("    margin: 0;");
            sb.AppendLine("    padding: 0;");
            sb.AppendLine("}");
            sb.AppendLine(".Container{");
            sb.AppendLine("    display: grid;");
            sb.AppendLine("    grid-template-columns: 1fr 1fr;");
            sb.AppendLine("    grid-template-rows: 1fr 1fr;");
            sb.AppendLine("    gap:0;");
            sb.AppendLine("    height: 25.54cm;");
            sb.AppendLine("    width: 18.9cm;");
            sb.AppendLine("}");
            sb.AppendLine(".Calendar{");
            sb.AppendLine("    display: flex;");
            sb.AppendLine("    flex-wrap: wrap;");
            sb.AppendLine("    border: 1px solid #000;");
            sb.AppendLine("    width: 9.45cm;");
            sb.AppendLine("    height: 12.77cm;");
            sb.AppendLine("    /* padding: .75cm; */");
            sb.AppendLine("}");
            sb.AppendLine(".Calendar .Imagen{");
            sb.AppendLine("    position: relative;");
            sb.AppendLine("    height: 6cm;");
            sb.AppendLine("    width: 8cm;");
            sb.AppendLine("    border: 1px solid #000;");
            sb.AppendLine("    margin: .15cm .75cm auto .75cm;");
            sb.AppendLine($"    background-image: url('{PathImg}');");
            sb.AppendLine("    background-position: center;");
            sb.AppendLine("    background-size: 100% 100%;");
            sb.AppendLine("    background-repeat: no-repeat;");
            sb.AppendLine("}");
            sb.AppendLine(".Calendar .Titulo{");
            sb.AppendLine("    position: absolute;");
            sb.AppendLine("    font-family: 'blackswordregular';");
            sb.AppendLine("    font-size: 1.5rem;");
            sb.AppendLine("    font-weight: 500;");
            sb.AppendLine($"    color: rgba({TituloColor.R}, {TituloColor.G}, {TituloColor.B}, {TituloColor.A});");
            sb.AppendLine($"    text-shadow: 3px 3px 1px rgba({TituloColor.R}, {TituloColor.G}, {TituloColor.B}, {TituloColor.A});");
            sb.AppendLine($"    left: {TituloX}px;");
            sb.AppendLine($"    top: {TituloY}px;");
            sb.AppendLine("}");
            sb.AppendLine(".Calendar .Mensaje{");
            sb.AppendLine("    position: relative;");
            sb.AppendLine("    color: #000;");
            sb.AppendLine("    margin: -3cm 0 auto .75cm;");
            sb.AppendLine("    font-family: 'blackswordregular';");
            sb.AppendLine("    font-size: 1.2rem;");
            sb.AppendLine("}");
            sb.AppendLine("@font-face {");
            sb.AppendLine("    font-family: 'blackswordregular';");
            sb.AppendLine("    src: url('HtmlDocs/Fonts/blacksword-webfont.woff2') format('woff2'),");
            sb.AppendLine("         url('HtmlDocs/Fonts/blacksword-webfont.woff') format('woff');");
            sb.AppendLine("    font-weight: normal;");
            sb.AppendLine("    font-style: normal;");
            sb.AppendLine("}");
            sb.AppendLine("    </style>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            sb.AppendLine("    <div class=\"Container\">");
            sb.AppendLine("        <div class=\"Calendar\">");
            sb.AppendLine("            <div class=\"Imagen\">");
            sb.AppendLine("            <label class=\"Titulo\">La Calera</label>");
            sb.AppendLine("            </div>");
            sb.AppendLine("            <label class=\"Mensaje\">Gentileza de Robinson Morales Soto Para:</label>");
            sb.AppendLine("        </div>");
            sb.AppendLine("        <div class=\"Calendar\">");
            sb.AppendLine("            <div class=\"Imagen\">");
            sb.AppendLine("            <label class=\"Titulo\">La Calera</label>");
            sb.AppendLine("            </div>");
            sb.AppendLine("            <label class=\"Mensaje\">Gentileza de Robinson Morales Soto Para:</label>");
            sb.AppendLine("        </div>");
            sb.AppendLine("        <div class=\"Calendar\">");
            sb.AppendLine("            <div class=\"Imagen\">");
            sb.AppendLine("            <label class=\"Titulo\">La Calera</label>");
            sb.AppendLine("            </div>");
            sb.AppendLine("            <label class=\"Mensaje\">Gentileza de Robinson Morales Soto Para:</label>");
            sb.AppendLine("        </div>");
            sb.AppendLine("        <div class=\"Calendar\">");
            sb.AppendLine("            <div class=\"Imagen\">");
            sb.AppendLine("            <label class=\"Titulo\">La Calera</label>");
            sb.AppendLine("            </div>");
            sb.AppendLine("            <label class=\"Mensaje\">Gentileza de Robinson Morales Soto Para:</label>");
            sb.AppendLine("        </div>");
            sb.AppendLine("        ");
            sb.AppendLine("    </div>");
            sb.AppendLine("    ");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            return sb.ToString();
        }
        public static string GetHmltText2(string PathImg, float TituloX, float TituloY, Color TituloColor, Color TituloSombraColor)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html lang=\"en\">");
            sb.AppendLine("<head>");
            sb.AppendLine("    <meta charset=\"UTF-8\">");
            sb.AppendLine("    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
            sb.AppendLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            sb.AppendLine("    <title>Document</title>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body style=\"margin: 10;padding: 0; \">");
            sb.AppendLine("    <div style=\"display: grid;grid-template-columns: 1fr 1fr;grid-template-rows: 1fr 1fr;gap:0;height: 25.54cm;width: 18.9cm; \">");
            sb.AppendLine("        <div style=\"display: flex;flex-wrap: wrap;border: 1px solid #000;width: 9.45cm;height: 12.77cm; \">");
            sb.AppendLine($"            <img style=\"position: relative;height: 6cm;width: 8cm;border: 1px solid #000;margin: .15cm .75cm auto .75cm; \" src=>\"file:///{PathImg}\"");
            sb.AppendLine($"            <label  style=\"position: absolute;font-family: 'Blacksword';font-size: 1.5rem;font-weight: 500;color: rgba({TituloColor.R}, {TituloColor.G}, {TituloColor.B}, {TituloColor.A});text-shadow: 3px 3px 1px rgba({TituloColor.R}, {TituloColor.G}, {TituloColor.B}, {TituloColor.A});left: {TituloX}px;top: {TituloY}px; \">La Calera</label>");
            sb.AppendLine("            <label  style=\"position: relative;color: #000;margin: -3cm 0 auto .75cm;font-family: 'Blacksword';font-size: 1.2rem; \">Gentileza de Robinson Morales Soto Para:</label>");
            sb.AppendLine("        </div>");
            sb.AppendLine("    </div>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            return sb.ToString();
        }
    }
}
