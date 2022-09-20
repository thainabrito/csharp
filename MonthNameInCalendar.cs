namespace month_name;
public class MonthNameInCalendar
{
    /// <summary>
    /// Esta função retorna o nome do mês passado como parâmetro de entrada.
    /// </summary>
    /// <param month="mes"> Um número inteiro com o mês. </param>   
    /// <returns> Nome do mês</returns>
    public static string MonthName(int month)
    {
        string monthName;

        if (month == 1) {
            monthName = "Janeiro";

        } else if (month == 2) {
            monthName = "Fevereiro";

        } else if (month == 3) {
            monthName = "Março";

        } else if (month == 4) {
            monthName = "Abril";

        } else if (month == 5) {
            monthName = "Maio";

        } else if (month == 6) {
            monthName = "Junho";

        } else if (month == 7) {
            monthName = "Julho";

        } else if (month == 8) {
            monthName = "Agosto";

        } else if (month == 9) {
            monthName = "Setembro";

        } else if (month == 10) {
            monthName = "Outubro";

        } else if (month == 11) {
            monthName = "Novembro";

        } else if (month == 12) {
            monthName = "Dezembro";

        } else {
            monthName = "inválido";
        }
        return monthName;
    }
}