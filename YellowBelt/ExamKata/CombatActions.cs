namespace ExamKata;

public static class CombatActions
{
    public static Action<Player, Enemy> Attack = (player, enemy) => CombatMethods.Attack(player, enemy);
    public static Action<Player> Heal = (player) => CombatMethods.Heal(player);
}