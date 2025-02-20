using System.Globalization;
using System.Runtime.CompilerServices;

namespace eAgenda.WinApp.Compartilhado;
public static class StringExtensions
{

    public static void ConfigurarGridZebrado(this DataGridView grid)
    {
        Font fonte = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point, 0);



        DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
        {
            BackColor = Color.LightGray,
            Font = fonte,
            ForeColor = Color.Black,
            SelectionBackColor = Color.LightYellow,
            SelectionForeColor = Color.Black,
        };

        grid.AlternatingRowsDefaultCellStyle = linhaEscura;

        DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
        {
            BackColor = Color.White,
            Font = fonte,
            SelectionBackColor = Color.LightYellow,
            SelectionForeColor = Color.Black
        };

        grid.RowsDefaultCellStyle = linhaClara;

    }
    public static string ToCapitalize(this string textoEscolhido)
    {
        if (textoEscolhido == null || textoEscolhido.Length < 2)
            return textoEscolhido;

        string[] textoSeparado = textoEscolhido.Split(' ');

        for (int i = 0; i < textoSeparado.Length; i++)
        {
            string palavraFormatada =
                CultureInfo.
                CurrentCulture.
                TextInfo.
                ToTitleCase(textoSeparado[i].ToLower());

            textoSeparado[i] = palavraFormatada;
        }

        return string.Join(" ", textoSeparado);
    }

}
