using System;

namespace Calculo_CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpfcliente;
            string cpf9;
            string cpf10 ,cpffinal;
            int contagem1=10, contagen2=11, resto=0, rs1=0, rs2=0;
            
            cpfcliente = "37420745803";
            cpf9 = cpfcliente.Substring(0,9);
            for(int i=0; i < cpf9.Length;i++)
            {
                rs1 += int.Parse(cpf9[i].ToString())*contagem1;
                contagem1--;

            }
            resto = rs1 % 11;
            if(resto < 2 )
            cpf10 = cpf9+0;
            else 
            cpf10 =cpf9+(11-resto);
            //cepfinal = cpf10;
            
            for(int i=0; i < cpf10.Length;i++)
            {
                rs2 += int.Parse(cpf10[i].ToString())*contagen2;
                contagen2--;
            }
            resto = rs2 % 11;
            if(resto < 2 )
            cpffinal = cpf10 + 0;
            else 
            cpffinal =cpf10+(11-resto);

            Console.WriteLine("os numero sao:"+cpffinal);

        }
    }
}
