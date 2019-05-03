using System.Numerics;

namespace KursachLibrary1
{
    internal interface IFactor
    {
        string Name { get; } //название алгоритма - для вывода информации на экран
        BigInteger Factor(BigInteger number); //метод, который раскладывает целое число на простые
    }
}
