namespace DogDaycareTracker.Core
{
    public interface IDog
    {
        bool HasAlreadyBeenVerified { get; set; }
        int Weight { set; get; }
    }
 }