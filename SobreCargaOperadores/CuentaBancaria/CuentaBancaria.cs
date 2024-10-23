using System;

class CuentaBancaria
{
    //atributos
    private string NombreTitular;
    private string NumeroCuenta;
    private decimal Balance;
   
    //constructor
    
    public CuentaBancaria(string NombreTitular, string NumeroCuenta, decimal cantidad)
    {
        SetNombreTitular(NombreTitular);
        SetNumeroCuenta(NumeroCuenta);
        Depositar(cantidad);
    }
    //constructor default
    public CuentaBancaria(){}
    
    public void SetNombreTitular(string NombreTitular)
    {
        this.NombreTitular=NombreTitular;  
    }
    public string GetNombreTitular(){return NombreTitular; }
    
    public void SetNumeroCuenta(string numero)
    {
        NumeroCuenta=numero;
    }
    
    public string GetNumeroCuenta(){return NumeroCuenta;}
    
    public decimal GetBalance(){return Balance;}
    public bool Depositar(decimal cantidad)
    {   bool resultado=false;
        if(cantidad>0)
        {
            Balance+=cantidad;
            resultado=true;
        }
        return resultado;
    }
     
    public bool Retirar(decimal cantidad)
    {   bool resultado=false;   
        if(cantidad>0 && cantidad<=Balance)
        {
            Balance-=cantidad;
            resultado=true;
        }
        return resultado;
    }

    
    public void MostrarDetalles()
    {
       Console.WriteLine("Nombre Titular :"+GetNombreTitular());
       Console.WriteLine("Número de cuenta :"+ GetNumeroCuenta());
       Console.WriteLine("Balance : "+GetBalance().ToString("C2"));
    }
    //sobrecarga de operadores
    public static CuentaBancaria operator +(CuentaBancaria cuenta, decimal cantidad)
    {
        cuenta.Depositar(cantidad);
        return cuenta;
    }
    public static CuentaBancaria operator -(CuentaBancaria cuenta, decimal cantidad)
    {
        cuenta.Retirar(cantidad);
        return cuenta;
    }	



   

    

}   