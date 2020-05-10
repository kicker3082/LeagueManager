namespace LeagueManager.Shared.Models
{
    public interface IPlayer : IPerson
    {
        new public static IPlayer Null = NullPlayer.Get();
    }

    public class NullPlayer : NullPerson, IPlayer
    {
        protected NullPlayer() { }
        private readonly static NullPlayer _single = new NullPlayer();

        new public static NullPlayer Get() => _single;
    }
}
