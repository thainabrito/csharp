using System.Globalization;
using System;

namespace CommissionCalculation;

public class CommissionCalculator
{
    public const decimal CommissionPerCarSold = 250;
    public const decimal CommissionPerTotalCarSold = 0.03M;
    public decimal FixedSalary { get; set; }
    public int AmountCarsSold { get; set; }
    public decimal TotalSalesValue { get; set; }
    public decimal FinalSalary { get; set; }

    public void CalculateFinalSalary( decimal fixedSalary, int amountCarsSold, decimal totalSalesValue)
    {
        FixedSalary = fixedSalary;

        AmountCarsSold = amountCarsSold;

        TotalSalesValue = totalSalesValue;

        FinalSalary =
            FixedSalary
            + (AmountCarsSold * CommissionPerCarSold)

            + (TotalSalesValue * CommissionPerTotalCarSold);
    }

    public string[] ShowFinalSalary(string contributorName, string month)
    {
        var commissionCarSold = AmountCarsSold * CommissionPerCarSold;

        var commissionTotalCarSold = TotalSalesValue * CommissionPerTotalCarSold;

        var showFinalSalary = new string[]
        {
            $"O colaborador {contributorName} neste mês de {month} obteve o salário final de R${ConvertNumberToStringWithDot(this.FinalSalary)} referente à:",
            
            $"SALARIO FIXO: R${ConvertNumberToStringWithDot(FixedSalary)}",
            
            $"TOTAL DE CARROS VENDIDOS: {AmountCarsSold}",
            
            $"VALOR TOTAL DE VENDAS NO MES: R${ConvertNumberToStringWithDot(TotalSalesValue)}",
            
            $"COMISSÃO POR CARROS VENDIDOS: R${ConvertNumberToStringWithDot(commissionCarSold)}",
            
            $"COMISSÃO DE 3% DO TOTAL DE VENDAS: R${ConvertNumberToStringWithDot(commissionTotalCarSold)}",
        };
        return showFinalSalary;
    }

    private static string ConvertNumberToStringWithDot(decimal number)
    {
        return number.ToString("N2", new CultureInfo("en-US"));
    }
}