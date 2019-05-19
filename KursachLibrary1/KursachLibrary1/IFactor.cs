using System.Numerics;

namespace KursachLibrary1
{
    /// <summary>
    /// Данный интерфейс декларирует поле и метод, которыми должны обладать алгоритмы факторизации
    /// </summary>
    internal interface IFactor
    {
        string Name { get; } // Название алгоритма - для вывода информации на экран
        BigInteger Factor(BigInteger number); // Метод, который возвращает делитель входного числа
    }
}
