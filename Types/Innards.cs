using System.Reflection;

namespace RandomProof.Types;

/// <summary>
/// Чтение внутренностей генератора. Класс Random сам ничего не считает:
/// он держит поле _impl с одной из двух реализаций и переадресует вызовы ей.
///
/// Имя поля задано строкой, поэтому смена реализации сломает чтение.
/// Сверка это заметит и остановит прогон.
/// </summary>
internal static class Innards
{
    /// <summary>Имя внутренней реализации или пояснение, почему его нет.</summary>
    internal static string ImplementationName(Random random)
    {
        FieldInfo? field = typeof(Random).GetField("_impl", BindingFlags.Instance | BindingFlags.NonPublic);
        if (field is null)
        {
            return "поле _impl не найдено";
        }

        object? value = field.GetValue(random);
        return value is null ? "реализация не задана" : value.GetType().Name;
    }
}
