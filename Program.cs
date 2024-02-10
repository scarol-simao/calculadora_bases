using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFinal
{


    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;
            while (opcao != 0)
            {
                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine("| Menu de conversão de base: |");
                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine("| 1. Decimal -> Binario      |");
                Console.WriteLine("| 2. Binário -> Decimal      |");
                Console.WriteLine("| 3. Decimal -> Octal        |");
                Console.WriteLine("| 4. Octal -> Decimal        |");
                Console.WriteLine("| 5. Decimal -> Hexadecimal  |");
                Console.WriteLine("| 6. Hexadecimal -> Decimal  |");
                Console.WriteLine("| 7. Binario -> Octal        |");
                Console.WriteLine("| 8. Octal -> Binario        |");
                Console.WriteLine("| 9. Binario -> Hexadecimal  |");
                Console.WriteLine("| 10. Hexadecimal -> Binario |");
                Console.WriteLine("| 11. Octal -> Hexadecimal   |");
                Console.WriteLine("| 12. Hexadecimal -> Octal   |");
                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine("| 0. Sair |");
                Console.WriteLine("|------------------------------------------------------------------|");
                Console.WriteLine("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        DecimalPBinário();
                        break;

                    case 2:
                        BinárioPDecimal();
                        break;
                    case 3:
                        DecimalPOctal();
                        break;
                    case 4:
                        OctalPDecimal();
                        break;
                    case 5:
                        DecimalPHexadecimal();
                        break;
                    case 6:
                        HexadecimalPDecimal();
                        break;
                    case 7:
                        BinárioPOctal();
                        break;
                    case 8:
                        OctalPBinário();
                        break;
                    case 9:
                        BinárioPHexadecimal();
                        break;
                    case 10:
                        HexadecimalPBinário();
                        break;
                    case 11:
                        OctalPHexadecimal();
                        break;
                    case 12:
                        HexadecimalPOctal();
                        break;
                    default:
                        Console.WriteLine("INVÁLIDO");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void DecimalPBinário()
        {
            int num, resultado, resto;

            Console.WriteLine("Insira um número decimal para ser convertido em binário: ");
            num = int.Parse(Console.ReadLine());

            string binario = "";

            while (num >= 1)
            {
                resultado = num / 2;
                resto = num % 2;
                binario = resto + binario;
                num = resultado;

                Console.WriteLine($"{num} / 2 = Quociente: {resultado}, Resto = {resto}");
            }
            Console.WriteLine("Resultado: " + binario);
            Console.ReadKey();
        }
        static void BinárioPDecimal()
        {
            Console.WriteLine("Insira um número que deseja converter de binário para decimal: ");
            int numeroBinario = int.Parse(Console.ReadLine());
            string numeroInvertido = new string(numeroBinario.ToString().Reverse().ToArray());
            double soma = 0;
            double expoente = 0;
            int numero;
            double somafinal = 0;

            for (int i = 0; i < numeroInvertido.Length; i++)
            {

                numero = int.Parse(numeroInvertido.Substring(i, 1));
                int calculoExpoente = (int)Math.Pow(2, expoente);
                soma = numero * calculoExpoente;
                expoente++;
                somafinal += (soma = numero * calculoExpoente);
                Console.WriteLine($"Soma atual: {numero} = {numero} * {calculoExpoente} = {soma}");
            }
            Console.WriteLine("O número convertido é: " + somafinal);
            Console.ReadKey();

        }
        static void DecimalPOctal()
        {
            {
                int num, resultado, resto;

                Console.WriteLine("Digite um número decimal para ser convertido em octal: ");
                num = int.Parse(Console.ReadLine());

                string binario = "";

                while (num >= 1)
                {
                    resultado = num / 8;
                    resto = num % 8;
                    binario = resto + binario;
                    num = resultado;

                    Console.WriteLine($"{num} / 8 = Quociente: {resultado}, Resto = {resto}");
                }
                Console.WriteLine("Resultado: " + binario);
            }
            Console.ReadKey();
        }
        static void OctalPDecimal()
        {
            {
                Console.WriteLine("Informe um número que deseja converter de octal para decimal: ");
                int numeroBinario = int.Parse(Console.ReadLine());
                string numeroInvertido = new string(numeroBinario.ToString().Reverse().ToArray());
                double soma = 0;
                double expoente = 0;
                int numero;
                double somafinal = 0;

                for (int i = 0; i < numeroInvertido.Length; i++)
                {

                    numero = int.Parse(numeroInvertido.Substring(i, 1));
                    int calculoExpoente = (int)Math.Pow(8, expoente);
                    soma = numero * calculoExpoente;
                    expoente++;
                    somafinal += (soma = numero * calculoExpoente);
                    Console.WriteLine($"Soma atual: {numero} = {numero} * {calculoExpoente} = {soma}");
                }

                Console.WriteLine("O número convertido é: " + somafinal);
                Console.ReadKey();

            }

        }
        static void DecimalPHexadecimal()
        {
            int num, divisao, resto;

            Console.WriteLine("Digite um número decimal para ser convertido em hexadecimal: ");
            num = int.Parse(Console.ReadLine());

            string hexadecimal = "";

            while (num >= 1)
            {
                divisao = num / 16;
                resto = num % 16;

                string restoLetra = " ";
                switch (resto)
                {
                    case 10:
                        restoLetra = "A";
                        break;
                    case 11:
                        restoLetra = "B";
                        break;
                    case 12:
                        restoLetra = "C";
                        break;
                    case 13:
                        restoLetra = "D";
                        break;
                    case 14:
                        restoLetra = "E";
                        break;
                    case 15:
                        restoLetra = "F";
                        break;
                    default:
                        restoLetra = resto.ToString();
                        break;
                }

                hexadecimal = restoLetra + hexadecimal;
                num = divisao;

                Console.WriteLine($"{num} / 8 = Quociente: {divisao}, Resto = {resto}");
            }
            Console.WriteLine("Resultado: " + hexadecimal);
            Console.ReadKey();
        }
        static void HexadecimalPDecimal()
        {

            Console.WriteLine("Informe um número que deseja converter de hexadecimal para decimal: ");
            string numeroHexa = Console.ReadLine();
            string numeroInvertido = new string(numeroHexa.ToString().Reverse().ToArray());
            double soma = 0;
            double expoente = 0;
            string numero;
            double somafinal = 0;

            for (int i = 0; i < numeroInvertido.Length; i++)
            {

                numero = (numeroInvertido.Substring(i, 1));
                int num2 = 0;
                switch (numero)
                {

                    case "0":
                        num2 = 0;
                        break;
                    case "1":
                        num2 = 1;
                        break;
                    case "2":
                        num2 = 2;
                        break;
                    case "3":
                        num2 = 3;
                        break;
                    case "4":
                        num2 = 4;
                        break;
                    case "5":
                        num2 = 5;
                        break;
                    case "6":
                        num2 = 6;
                        break;
                    case "7":
                        num2 = 7;
                        break;
                    case "8":
                        num2 = 8;
                        break;
                    case "9":
                        num2 = 9;
                        break;
                    case "A":
                        num2 = 10;
                        break;
                    case "B":
                        num2 = 11;
                        break;
                    case "C":
                        num2 = 12;
                        break;
                    case "D":
                        num2 = 13;
                        break;
                    case "E":
                        num2 = 14;
                        break;
                    case "F":
                        num2 = 15;
                        break;
                    default:
                        break;
                }


                int calculoExpoente = (int)Math.Pow(16, expoente);
                soma = num2 * calculoExpoente;
                expoente++;
                somafinal += (soma = num2 * calculoExpoente);
                Console.WriteLine($"Soma atual: {numero} = {numero} * {calculoExpoente} = {soma}");
            }
            Console.WriteLine("O número convertido é: " + somafinal);
            Console.ReadKey();
        }
        static void BinárioPOctal()
        {
            string numero, temp, numbinario = "", octal = "";
            int count = 0;
            Console.WriteLine("Insira um número binário para ser convertido em octal: ");
            numero = Console.ReadLine();
            for (int i = 0; i <= numero.Length - 1; i++)
            {
                count = count + 1;
                if (count == 3)
                {
                    count = 0;
                }
            }
            temp = numero;
            if (count == 1)
            {
                numero = "00" + temp;
            }
            if (count == 2)
            {

                numero = "0" + temp;
            }

            for (int i = 0; i <= numero.Length - 1; i++)
            {
                numbinario += numero.Substring(i, 1);
                if (numbinario.Length == 3)
                {
                    octal += FunçãoOctal(numbinario);
                    numbinario = "";
                }
            }
            Console.WriteLine("Resultado é " + octal);

            Console.ReadKey();
        }
        static string FunçãoOctal(string converter)
        {
            string valor = "";
            switch (converter)
            {
                case "000":
                    valor = "0";
                    break;
                case "001":
                    valor = "1";
                    break;
                case "010":
                    valor = "2";
                    break;
                case "011":
                    valor = "3";
                    break;
                case "100":
                    valor = "4";
                    break;
                case "101":
                    valor = "5";
                    break;
                case "110":
                    valor = "6";
                    break;
                case "111":
                    valor = "7";
                    break;
                default:
                    break;
            }
            return valor;


        }
        static void OctalPBinário()
        {
            Console.WriteLine("Insira um número octal para conversão em binário: ");
            string octal = Console.ReadLine();

            string[] vetor2 = { "000", "001", "010", "011", "100", "101", "110", "111" };


            string binario = "";

            foreach (char digito in octal)
            {

                int digitoOctal = int.Parse(digito.ToString());
                string digitoBinario = vetor2[digitoOctal];


                binario += digitoBinario;
            }

            Console.WriteLine("O número binário correspondente é: " + binario);
            Console.ReadKey();

        }

        static void BinárioPHexadecimal()
        {
            {
                string numero, temp, numbinario = "", hexadecimal = "";
                int count = 0;
                Console.WriteLine("Insira o número binário para ser convertido em hexadecimal: ");
                numero = Console.ReadLine();

                for (int i = 0; i <= numero.Length - 1; i++)
                {
                    count += 1;
                    if (count == 4)
                    {
                        count = 0;
                    }
                }
                temp = numero;
                if (count == 1)
                {
                    numero = "000" + temp;
                }
                if (count == 2)
                {
                    numero = "00" + temp;
                }
                if (count == 3)
                {
                    numero = "0" + temp;
                }
                for (int i = 0; i <= numero.Length - 1; i++)
                {
                    numbinario += numero.Substring(i, 1);
                    if (numbinario.Length == 4)
                    {
                        hexadecimal += FunçãoHexadecimal(numbinario);
                        numbinario = "";
                    }
                }
                Console.WriteLine("Resultado é " + hexadecimal);

                Console.ReadKey();
            }
        }
        static string FunçãoHexadecimal(string converter)
        {
            string valor = "";
            switch (converter)
            {
                case "0000":
                    valor = "0";
                    break;
                case "0001":
                    valor = "1";
                    break;
                case "0010":
                    valor = "2";
                    break;
                case "0011":
                    valor = "3";
                    break;
                case "0100":
                    valor = "4";
                    break;
                case "0101":
                    valor = "5";
                    break;
                case "0110":
                    valor = "6";
                    break;
                case "0111":
                    valor = "7";
                    break;
                case "1000":
                    valor = "8";
                    break;
                case "1001":
                    valor = "9";
                    break;
                case "1010":
                    valor = "A";
                    break;
                case "1011":
                    valor = "B";
                    break;
                case "1100":
                    valor = "C";
                    break;
                case "1101":
                    valor = "D";
                    break;
                case "1110":
                    valor = "E";
                    break;
                case "1111":
                    valor = "F";
                    break;
                default:
                    break;
            }
            return valor;


        }
        static void HexadecimalPBinário()
        {
            string hexadecimal = "", numero;
            Console.WriteLine("Insira um número hexadecimal para conversão em binário: ");
            numero = Console.ReadLine();

            for (int i = 0; i < numero.Length; i++)
            {
                switch (numero.Substring(i, 1))
                {
                    case "0":
                        hexadecimal += "0000";
                        break;
                    case "1":
                        hexadecimal += "0001";
                        break;
                    case "2":
                        hexadecimal += "0010";
                        break;
                    case "3":
                        hexadecimal += "0011";
                        break;
                    case "4":
                        hexadecimal += "0100";
                        break;
                    case "5":
                        hexadecimal += "0101";
                        break;
                    case "6":
                        hexadecimal += "0110";
                        break;
                    case "7":
                        hexadecimal += "0111";
                        break;
                    case "8":
                        hexadecimal += "1000";
                        break;
                    case "9":
                        hexadecimal += "1001";
                        break;
                    case "A":
                        hexadecimal += "1010";
                        break;
                    case "B":
                        hexadecimal += "1011";
                        break;
                    case "C":
                        hexadecimal += "1100";
                        break;
                    case "D":
                        hexadecimal += "1101";
                        break;
                    case "E":
                        hexadecimal += "1110";
                        break;
                    case "F":
                        hexadecimal += "1111";
                        break;
                }

            }
            Console.Write("O resultado é: " + hexadecimal);
        }
        static void OctalPHexadecimal()
        {
            Console.WriteLine("Digite o número octal para conversão em hexadecimal: ");
            string octal = Console.ReadLine();

            string hexadecimal = OctalParaHexadecimal(octal);

            Console.WriteLine("O número hexadecimal correspondente é: " + hexadecimal);
        }

        static string OctalParaHexadecimal(string octal)
        {
            string[] vetor2 = { "000", "001", "010", "011", "100", "101", "110", "111" };
            string binario = "";

            foreach (char digito in octal)
            {
                int digitoOctal = int.Parse(digito.ToString());
                string digitoBinario = vetor2[digitoOctal];
                binario += digitoBinario;
            }

            return BinarioParaHexadecimal(binario);
        }

        static string BinarioParaHexadecimal(string binario)
        {
            string hexa = "";

            while (binario.Length % 4 != 0)
            {
                binario = "0" + binario;
            }

            for (int i = 0; i < binario.Length; i += 4)
            {
                string grupo = binario.Substring(i, 4);
                hexa += FunçãoHexa(grupo);
            }

            return hexa;
        }

        static string FunçãoHexa(string converter)
        {
            string valor = "";
            switch (converter)
            {
                case "0000":
                    valor = "0";
                    break;
                case "0001":
                    valor = "1";
                    break;
                case "0010":
                    valor = "2";
                    break;
                case "0011":
                    valor = "3";
                    break;
                case "0100":
                    valor = "4";
                    break;
                case "0101":
                    valor = "5";
                    break;
                case "0110":
                    valor = "6";
                    break;
                case "0111":
                    valor = "7";
                    break;
                case "1000":
                    valor = "8";
                    break;
                case "1001":
                    valor = "9";
                    break;
                case "1010":
                    valor = "A";
                    break;
                case "1011":
                    valor = "B";
                    break;
                case "1100":
                    valor = "C";
                    break;
                case "1101":
                    valor = "D";
                    break;
                case "1110":
                    valor = "E";
                    break;
                case "1111":
                    valor = "F";
                    break;
                default:
                    break;
            }
            return valor;
        }
        static void HexadecimalPOctal()
        {
            Console.WriteLine("Digite o número hexadecimal para conversão em octal: ");
            string hexadecimal = Console.ReadLine();

            string octal = HexadecimalParaOctal(hexadecimal);

            Console.WriteLine("O número octal correspondente é: " + octal);
            Console.ReadKey();
        }

        static string HexadecimalParaOctal(string hexadecimal)
        {
            string binario = HexadecimalParaBinario(hexadecimal);
            return BinarioParaOctal(binario);
        }

        static string HexadecimalParaBinario(string hexadecimal)
        {
            string[] vetor16 = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            string binario = "";

            foreach (char digitoHexa in hexadecimal)
            {
                int digitoDecimal = Convert.ToInt32(digitoHexa.ToString(), 16);
                string digitoBinario = vetor16[digitoDecimal];
                binario += digitoBinario;
            }

            return binario;
        }

        static string BinarioParaOctal(string binario)
        {
            while (binario.Length % 3 != 0)
            {
                binario = "0" + binario;
            }

            string octal = "";

            for (int i = 0; i < binario.Length; i += 3)
            {
                string grupo = binario.Substring(i, 3);
                octal += FuncaoOctal(grupo);
            }

            return octal;
        }

        static string FuncaoOctal(string converter)
        {
            string valor = "";
            switch (converter)
            {
                case "000":
                    valor = "0";
                    break;
                case "001":
                    valor = "1";
                    break;
                case "010":
                    valor = "2";
                    break;
                case "011":
                    valor = "3";
                    break;
                case "100":
                    valor = "4";
                    break;
                case "101":
                    valor = "5";
                    break;
                case "110":
                    valor = "6";
                    break;
                case "111":
                    valor = "7";
                    break;
                default:
                    break;
            }
            return valor;
        }



    }
}

