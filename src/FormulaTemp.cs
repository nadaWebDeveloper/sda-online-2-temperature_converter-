class FormulaTemp{
    public static string F_to_C_Formula(double F)
    {
        return $"\n[({F:F3} - 32) * 5 / 9]";
    }

    public static string C_to_F_Formula(double C)
    {
        return $"\n[({C:F3} * 9 / 5) + 32]";
    }

    public static string C_to_K_Formula(double C)
    {
        return $"\n[{C:F3} + 273.15]";
    }

    public static string K_to_C_Formula(double K)
    {
        return $"\n[{K:F3} - 273.15]";
    }
    public static string K_to_F_Formula(double K)
    {
        var celsius = ConvertTemp.K_to_C(K);
        var celsiusFormula =K_to_C_Formula(K);
        var fahrenheit = C_to_F_Formula(celsius);
        return celsiusFormula + fahrenheit ;
    }

    public static string F_to_K_Formula(double F)
    {
        var celsius = ConvertTemp.F_to_C(F);
        var celsiusFormula = F_to_C_Formula(F);
        var kelvin = C_to_K_Formula(celsius);
        return celsiusFormula + kelvin;
    }
}