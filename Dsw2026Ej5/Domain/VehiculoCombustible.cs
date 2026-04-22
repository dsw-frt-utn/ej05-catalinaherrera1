using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class VehiculoCombustible: Vehiculo
{
    private double kilometrosPorLitro;
    private double litrosExtra;

    public VehiculoCombustible(string patente, string marca, string modelo, int anio, double capacidadCarga, 
        Sucursal sucursal, double kilometrosPorLitro, double litrosExtra) : base(VehiculoTipo.Combustible, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        this.kilometrosPorLitro = kilometrosPorLitro;
        this.litrosExtra = litrosExtra;
    }

    public double GetKilometrosPorLitro()
    {
        return kilometrosPorLitro;
    }

    public double GetLitrosExtra()
    {
        return litrosExtra;
    }

    public int CalcularEdad()
    {
        int edad = 2026 - GetAnio();
        return edad;
    }

    public override double CalcularConsumo(double kilometros)
    {
        double litrosTotales;
        if(CalcularEdad() > 5){
            double litrosViejo = litrosExtra * (kilometros / 15);
            litrosTotales = litrosViejo + (kilometros / kilometrosPorLitro);
            
        } else { 
            litrosTotales = kilometros / kilometrosPorLitro; 
        }

        return Math.Round(litrosTotales,2);
    }
}
