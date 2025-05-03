using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class PatenteGenerator
    {
        private const int LetterCombos = 26 * 26;  // 676
        private const int MaxNumber = 1000;     // 000..999

        private int _prefixIndex;
        private int _numericIndex;
        private int _suffixIndex;

        /// <summary>
        /// Crea un generador en memoria que comienza en la patente indicada.
        /// </summary>
        /// <param name="startPlate">Patente desde la cual arrancar (ej: "AA000AA").</param>
        public PatenteGenerator(string startPlate = "AA000AA")
        {
            ParsePlate(startPlate, out _prefixIndex, out _numericIndex, out _suffixIndex);
        }

        /// <summary>
        /// Devuelve la siguiente patente de la secuencia y avanza el generador.
        /// </summary>
        public string Next()
        {
            // 1) Construyo la patente actual
            string plate = $"{IndexToLetters(_prefixIndex)}{_numericIndex:000}{IndexToLetters(_suffixIndex)}";

            // 2) Avanzo índices para la próxima llamada
            IncrementIndices();

            return plate;
        }

        private void IncrementIndices()
        {
            _suffixIndex++;
            if (_suffixIndex >= LetterCombos)
            {
                _suffixIndex = 0;
                _numericIndex++;
                if (_numericIndex >= MaxNumber)
                {
                    _numericIndex = 0;
                    _prefixIndex++;
                    if (_prefixIndex >= LetterCombos)
                    {
                        throw new InvalidOperationException("Se agotaron las patentes disponibles.");
                    }
                }
            }
        }

        private static void ParsePlate(string plate, out int prefix, out int numeric, out int suffix)
        {
            // Formato "XX000XX"
            prefix = LettersToIndex(plate.Substring(0, 2));
            numeric = int.Parse(plate.Substring(2, 3));
            suffix = LettersToIndex(plate.Substring(5, 2));
        }

        private static string IndexToLetters(int idx)
        {
            int hi = idx / 26;
            int lo = idx % 26;
            return $"{(char)('A' + hi)}{(char)('A' + lo)}";
        }

        private static int LettersToIndex(string letters)
        {
            // 'AA' -> 0, 'AB' -> 1, ..., 'AZ' -> 25, 'BA' -> 26, etc.
            return (letters[0] - 'A') * 26 + (letters[1] - 'A');
        }
    }

}
