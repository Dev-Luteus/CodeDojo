namespace Kata5;

public class Game
{
    private readonly ILogger _logger;
    private readonly CharacterManager _characterManager;
    
    public Game(ILogger logger, CharacterManager characterManager)
    {
        _logger = logger;
        _characterManager = characterManager;
    }
    
    public void Start()
    {
        // It was not asked of me to create a maximum health value, so healing goes above max and does not clamp
        _logger.Log("Game started!\n");
       
        var arin = _characterManager.CreateWarrior("Arin", 100, 30);
        var bran = _characterManager.CreateHealer("Bran", 70, 40);
        var cara = _characterManager.CreateMage("Cara", 70, 20);
        var goblin = _characterManager.CreateEnemy("Goblin", 50, 20);
        
        _characterManager.DisplayAllCharacters();
        _logger.Log("\n...\n");
        
        arin.UseAbility(goblin);
        goblin.UseAbility(arin);
        bran.UseAbility(arin);
        cara.UseAbility(goblin);
    }
}
