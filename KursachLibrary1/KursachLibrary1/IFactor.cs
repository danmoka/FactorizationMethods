using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Данный интерфейс декларирует поле и метод, которыми должны обладать алгоритмы факторизации
    /// </summary>
    internal interface IFactor
    {
        string Name { get; } //название алгоритма - для вывода информации на экран
        BigInteger Factor(BigInteger number); //метод, который раскладывает целое число на простые
    }
}
