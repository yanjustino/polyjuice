using System;
using System.Text;
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
            _dig1,
            _dig2,
            _error,
            _partOne,
            _partTwo,
            _partThree,
            _partFive,
            _pateSix,
            _partSeven;

        private static int[] Number { get; } = new int[13];
        private static Random Rand { get; } = new Random();

        #region CPF

        public static string CpfComMascara()
        {
            var result = new StringBuilder();
            CreateCpfArray();

            for (_i = 1; _i <= 9; _i++)
            {
                result.Append(Convert.ToString(Number[_i]));
                if (_i - 1 == 2) result.Append(".");
                if (_i - 1 == 5) result.Append(".");
            }

            result.Append("-");
            result.Append(_dig1);
            result.Append(_dig2);
            result.AppendLine();

            return result.ToString();
        }

        public static string CpfSemMascara()
        {
            var result = new StringBuilder();

            CreateCpfArray();

            for (_i = 1; _i <= 9; _i++)
                result.Append(Convert.ToString(Number[_i]));

            result.Append(_dig1);
            result.Append(_dig2);
            result.AppendLine();

            return result.ToString();
        }

        private static void CreateCpfArray()
        {
            for (_i = 1; _i <= 9; _i++)
            {
                _error = 1;
                do
                {
                    if (_error > 1) _error = 1;
                    Number[_i] = (Rand.Next()) % 9;
                    _error++;
                } while (Number[_i] > 9 || Number[_i] < 0);
            }

            PrimeiroDigitoVerificadorCpf();
            SegundoDigitoVerificadorCpf();
        }

        private static void PrimeiroDigitoVerificadorCpf()
        {
            _sumOne = ((Number[1] * 10) +
                       (Number[2] * 9) +
                       (Number[3] * 8) +
                       (Number[4] * 7) +
                       (Number[5] * 6) +
                       (Number[6] * 5) +
                       (Number[7] * 4) +
                       (Number[8] * 3) +
                       (Number[9] * 2));
            _partOne = (_sumOne / 11);
            _partTwo = (_partOne * 11);
            _partThree = (_sumOne - _partTwo);

            _dig1 = (11 - _partThree);
            if (_dig1 > 9) _dig1 = 0;
        }

        private static void SegundoDigitoVerificadorCpf()
        {
            _sumTwo = ((Number[1] * 11) +
                       (Number[2] * 10) +
                       (Number[3] * 9) +
                       (Number[4] * 8) +
                       (Number[5] * 7) +
                       (Number[6] * 6) +
                       (Number[7] * 5) +
                       (Number[8] * 4) +
                       (Number[9] * 3) +
                       (_dig1 * 2));
            _partFive = (_sumTwo / 11);
            _pateSix = (_partFive * 11);
            _partSeven = (_sumTwo - _pateSix);
            _dig2 = (11 - _partSeven);
            if (_dig2 > 9) _dig2 = 0;
        }

        #endregion

        #region CNPJ

        public static string CnpjComMascara()
        {
            var result = new StringBuilder();
            CreateCnpjArray();

            for (_i = 1; _i <= 12; _i++)
            {
                result.Append(Convert.ToString(Number[_i]));
                if (_i == 2) result.Append("."); //imprime um ponto depois da 2ª casa
                if (_i == 5) result.Append("."); //imprime um ponto depois da 5ª casa
                if (_i == 8) result.Append("/"); //imprime uma barra depois da 8ª casa
            }

            result.Append("-");
            result.Append(_dig1);
            result.Append(_dig2);
            result.AppendLine();

            return result.ToString();
        }

        public static string CnpjSemMascara()
        {
            var result = new StringBuilder();
            CreateCnpjArray();

            for (_i = 1; _i <= 12; _i++)
                result.Append(Convert.ToString(Number[_i]));

            result.Append(_dig1);
            result.Append(_dig2);
            result.AppendLine();

            return result.ToString();
        }

        private static void CreateCnpjArray()
        {
            for (_i = 1; _i <= 8; _i++)
                Number[_i] = (Rand.Next()) % 9;

            Number[9] = 0;
            Number[10] = 0;
            Number[11] = 0;
            Number[12] = (Rand.Next()) % 9;

            PrimeiroDigitoVerificadorCnpj();
            SegundoDigitoVerificadorCnpj();
        }

        private static void SegundoDigitoVerificadorCnpj()
        {
            _sumTwo = ((Number[1] * 6) +
                       (Number[2] * 5) +
                       (Number[3] * 4) +
                       (Number[4] * 3) +
                       (Number[5] * 2) +
                       (Number[6] * 9) +
                       (Number[7] * 8) +
                       (Number[8] * 7) +
                       (Number[9] * 6) +
                       (Number[10] * 5) +
                       (Number[11] * 4) +
                       (Number[12] * 3) +
                       (_dig1 * 2));
            _partFive = (_sumTwo / 11);
            _pateSix = (_partFive * 11);
            _partSeven = (_sumTwo - _pateSix);
            _dig2 = (11 - _partSeven);
            if (_dig2 > 9) _dig2 = 0;
        }

        private static void PrimeiroDigitoVerificadorCnpj()
        {
            _sumOne = ((Number[1] * 5) +
                       (Number[2] * 4) +
                       (Number[3] * 3) +
                       (Number[4] * 2) +
                       (Number[5] * 9) +
                       (Number[6] * 8) +
                       (Number[7] * 7) +
                       (Number[8] * 6) +
                       (Number[9] * 5) +
                       (Number[10] * 4) +
                       (Number[11] * 3) +
                       (Number[12] * 2));
            _partOne = (_sumOne / 11);
            _partTwo = (_partOne * 11);
            _partThree = (_sumOne - _partTwo);
            _dig1 = (11 - _partThree);
            if (_dig1 > 9) _dig1 = 0;
        }

        #endregion
    }
}