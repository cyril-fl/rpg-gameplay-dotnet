using rpg_gameplay.model.characters.components;

namespace rpg_gameplay.logic.factories;

public static class StatListFactory
{
    public static StatList MergeList(List<StatList> sources)
    {
        StatList merged = new StatList(
            Merge([.. sources.Select(s => s.Mp)]),
            Merge([.. sources.Select(s => s.Str)]),
            Merge([.. sources.Select(s => s.Int)]),
            Merge([.. sources.Select(s => s.Agi)]),
            Merge([.. sources.Select(s => s.Con)]),
            Merge([.. sources.Select(s => s.Dex)]),
            Merge([.. sources.Select(s => s.Wis)]),
            Merge([.. sources.Select(s => s.Cha)]),
            Merge([.. sources.Select(s => s.Hp)])
        )
        { };
        
        return merged;
    }

    private static Stat Merge(List<Stat> stats)
    {
        int value = stats.Sum(s => s.Value);
        int? maxValue = stats.Any(s => s.MaxValue.HasValue)
            ? stats.Sum(s => s.MaxValue ?? 0)
            : null;

        var merged = new Stat(value, maxValue);

        foreach (var stat in stats)
        {
            merged.Modifiers.AddRange(stat.Modifiers);
        }

        return merged;
    }
}