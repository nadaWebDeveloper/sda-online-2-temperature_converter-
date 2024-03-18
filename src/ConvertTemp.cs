class ConvertTemp
{
    public static double F_to_C(double F)
    {
        return (F - 32) * 5 / 9;
    }

    public static double C_to_F(double C)
    {
        return (C * 9 / 5) + 32;
    }

    public static double C_to_K(double C)
    {
        return C + 273.15;
    }

    public static double K_to_C(double K)
    {
        return K - 273.15;
    }
    public static double K_to_F(double K)
    {
        var celsius = K_to_C(K);
        var fahrenheit = C_to_F(celsius);
        return fahrenheit;
    }

    public static double F_to_K(double F)
    {
        var celsius = F_to_C(F);
        var kelvin = C_to_K(celsius);
        return kelvin;
    }
}