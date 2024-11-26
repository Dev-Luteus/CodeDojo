namespace ExamKata
{
    public interface IAbility
    {
        int ManaCost { get; }
        
        void Use(Character user, Character target, ILogger logger);
    }

    public abstract class Luck
    {
        protected readonly Random luck = new Random();
    }

    public class Pass : IAbility
    {
        public int ManaCost => 0;

        public void Use(Character user, Character target, ILogger logger)
        {
            logger.Log($"> {user.Name} passed their turn! <");
        }
    }

    public class Fireball : Luck, IAbility
    {
        public int ManaCost => 15;

        public void Use(Character user, Character target, ILogger logger)
        {
            int damage = user.Amount + luck.Next(5, 15);
            
            logger.Log($"{user.Name} hurls a fireball at {target.Name} dealing {damage} damage!");
            target.ChangeHealth(-damage);
        }
    }

    public class IceBlast : Luck, IAbility
    {
        public int ManaCost => 25;

        public void Use(Character user, Character target, ILogger logger)
        {
            int damage = user.Amount + luck.Next(10, 25);
            
            logger.Log($"{user.Name} shoots an ice blast at {target.Name} dealing {damage} damage!");
            target.ChangeHealth(-damage);
        }
    }

    public class HealAlly : IAbility
    {
        public int ManaCost => 20;

        public void Use(Character user, Character target, ILogger logger)
        {
            logger.Log($"{user.Name} heals {target.Name} for {user.Amount} points!");
            target.ChangeHealth(user.Amount);
        }
    }

    public class HealSelf : IAbility
    {
        public int ManaCost => 20;

        public void Use(Character user, Character target, ILogger logger)
        {
            logger.Log($"{user.Name} heals themselves for {user.Amount} points!");
            user.ChangeHealth(user.Amount);
        }
    }

    public class Sword : IAbility
    {
        public int ManaCost => 0;

        public void Use(Character user, Character target, ILogger logger)
        {
            int damage = user.Amount;
            
            logger.Log($"{user.Name} slashes with their sword towards {target.Name} dealing {damage} damage!");
            target.ChangeHealth(-damage);
        }
    }

    public class Defend : IAbility
    {
        public int ManaCost => 0;

        public void Use(Character user, Character target, ILogger logger)
        {
            user.IsDefending = true;
            logger.Log($"{user.Name} braces for defense, reducing incoming damage.");
        }
    }
}
