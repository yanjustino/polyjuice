using System;
using Polyjuice.Extension;

namespace Polyjuice.Potions.PtBr
{
    public static class Identification
    {
        public static string Rg => "#########".Numerify();
        public static string PrettyRg => "###.###.###".Numerify();
        public static string Cpf => NumberGenerator.CpfSemMascara();
        public static string PrettyCpf => NumberGenerator.CpfComMascara();
        public static string Cnpj => NumberGenerator.CnpjSemMascara();
        public static string PrettyCnpj => NumberGenerator.CnpjComMascara();
    }

    /// <summary>
    /// Thanks to:
    /// https://github.com/luan122/Gerador-de-CNPJ-e-CPF
    /// TODO: This class needs refactoring for modernizing csharp code and achieve performance issues
    /// </summary>
    internal static class NumberGenerator
    {
        private static int _sumOne,
            _sumTwo,
            _i,
            _error,
            _cnpj,
            _cpf,
            _partOne,
            _parteTwo,
            _parteThree,
            _dig1,
            _parteFive,
            _parteSix,
            _parteSeven,
            _dig2;

        private static int[] _number = new int[13];
        private static Random _rand = new Random();

        public static string CpfComMascara(int size = 1)
        {
            var result = "";
            for (_cpf = 1; _cpf <= size; _cpf++)
            {
                for (_i = 1; _i <= 9; _i++)
                {
                    _error = 1;
                    do
                    {
                        if (_error > 1) _error = 1;
                        _number[_i] = (_rand.Next()) % 9;
                        _error++;
                    } while (_number[_i] > 9 || _number[_i] < 0);
                }

                PrimeiroDigitoVerificadorCpf();
                SegundoDigitoVerificadorCpf();
                //*==========================================*
                //|       Impressao do numero completo       | 
                //*==========================================*
                for (_i = 1; _i <= 9; _i++)
                {
                    result += Convert.ToString(_number[_i]);
                    if (_i - 1 == 2) result += ".";
                    if (_i - 1 == 5) result += ".";
                }

                result += "-" + _dig1 + _dig2 + Environment.NewLine; // dois últimos digitos
            }

            return result;
        }

        private static void SegundoDigitoVerificadorCpf()
        {
            _sumTwo = ((_number[1] * 11) +
                       (_number[2] * 10) +
                       (_number[3] * 9) +
                       (_number[4] * 8) +
                       (_number[5] * 7) +
                       (_number[6] * 6) +
                       (_number[7] * 5) +
                       (_number[8] * 4) +
                       (_number[9] * 3) +
                       (_dig1 * 2));
            _parteFive = (_sumTwo / 11);
            _parteSix = (_parteFive * 11);
            _parteSeven = (_sumTwo - _parteSix);
            _dig2 = (11 - _parteSeven);
            if (_dig2 > 9) _dig2 = 0;
        }

        private static void PrimeiroDigitoVerificadorCpf()
        {
            _sumOne = ((_number[1] * 10) +
                       (_number[2] * 9) +
                       (_number[3] * 8) +
                       (_number[4] * 7) +
                       (_number[5] * 6) +
                       (_number[6] * 5) +
                       (_number[7] * 4) +
                       (_number[8] * 3) +
                       (_number[9] * 2));
            _partOne = (_sumOne / 11);
            _parteTwo = (_partOne * 11);
            _parteThree = (_sumOne - _parteTwo);

            _dig1 = (11 - _parteThree);
            if (_dig1 > 9) _dig1 = 0;
        }

        public static string CpfSemMascara(int size = 1)
        {
            var result = "";
            for (_cpf = 1; _cpf <= size; _cpf++)
            {
                for (_i = 1; _i <= 9; _i++)
                {
                    _error = 1;
                    do
                    {
                        if (_error > 1)
                        {
                            _error = 1;
                        }

                        _number[_i] = (_rand.Next()) % 9;
                        _error++;
                    } while (_number[_i] > 9 || _number[_i] < 0);
                }

                PrimeiroDigitoVerificadorCpf();
                SegundoDigitoVerificadorCpf();
                //*==========================================*
                //|       Impressao do numero completo       | 
                //*==========================================*
                for (_i = 1; _i <= 9; _i++)
                {
                    result += Convert.ToString(_number[_i]);
                }

                result += _dig1 + "" + _dig2 + Environment.NewLine;
            }

            return result;
        }

        public static string CnpjComMascara(int size = 1)
        {
            String result = "";
            for (_cnpj = 1; _cnpj <= size; _cnpj++)
            {
                for (_i = 1; _i <= 8; _i++)
                {
                    _number[_i] = (_rand.Next()) % 9;
                }

                _number[9] = 0;
                _number[10] = 0;
                _number[11] = 0;
                _number[12] = (_rand.Next()) % 9;
                PrimeiroDigitoVerificadorCnpj();
                SegundoDigitoVerificadorCnpj();
                //*==========================================*
                //|       Impressao do numero completo       | 
                //*==========================================*
                for (_i = 1; _i <= 12; _i++)
                {
                    result += Convert.ToString(_number[_i]);
                    if (_i == 2) result += "."; //imprime um ponto depois da 2ª casa
                    if (_i == 5) result += "."; //imprime um ponto depois da 5ª casa
                    if (_i == 8) result += "/"; //imprime uma barra depois da 8ª casa
                }

                result += "-" + _dig1 + "" + _dig2 + Environment.NewLine; // dois últimos digitos
            }

            return result;
        }

        private static void SegundoDigitoVerificadorCnpj()
        {
            _sumTwo = ((_number[1] * 6) +
                       (_number[2] * 5) +
                       (_number[3] * 4) +
                       (_number[4] * 3) +
                       (_number[5] * 2) +
                       (_number[6] * 9) +
                       (_number[7] * 8) +
                       (_number[8] * 7) +
                       (_number[9] * 6) +
                       (_number[10] * 5) +
                       (_number[11] * 4) +
                       (_number[12] * 3) +
                       (_dig1 * 2));
            _parteFive = (_sumTwo / 11);
            _parteSix = (_parteFive * 11);
            _parteSeven = (_sumTwo - _parteSix);
            _dig2 = (11 - _parteSeven);
            if (_dig2 > 9) _dig2 = 0;
        }

        private static void PrimeiroDigitoVerificadorCnpj()
        {
            _sumOne = ((_number[1] * 5) +
                       (_number[2] * 4) +
                       (_number[3] * 3) +
                       (_number[4] * 2) +
                       (_number[5] * 9) +
                       (_number[6] * 8) +
                       (_number[7] * 7) +
                       (_number[8] * 6) +
                       (_number[9] * 5) +
                       (_number[10] * 4) +
                       (_number[11] * 3) +
                       (_number[12] * 2));
            _partOne = (_sumOne / 11);
            _parteTwo = (_partOne * 11);
            _parteThree = (_sumOne - _parteTwo);
            _dig1 = (11 - _parteThree);
            if (_dig1 > 9) _dig1 = 0;
        }

        public static string CnpjSemMascara(int size = 1)
        {
            String result = "";
            for (_cnpj = 1; _cnpj <= size; _cnpj++)
            {
                for (_i = 1; _i <= 8; _i++)
                {
                    _number[_i] = (_rand.Next()) % 9;
                }

                _number[9] = 0;
                _number[10] = 0;
                _number[11] = 0;
                _number[12] = (_rand.Next()) % 9;
                
                PrimeiroDigitoVerificadorCnpj();
                SegundoDigitoVerificadorCnpj();
                //*==========================================*
                //|       Impressao do numero completo       | 
                //*==========================================*
                //ostrm.SetLength(0);
                for (_i = 1; _i <= 12; _i++)
                {
                    result += Convert.ToString(_number[_i]);
                }
                result += _dig1 + "" + _dig2 + Environment.NewLine;
            }

            return result;
        }
    }
}