public class Game {
    public string Title;
    public string Genre;
    public int Rating;
    public int HoursPlayed;

    public Game(string title, string genre, int rating) {
        Title = title;
        Genre = genre;
        Rating = rating;
        HoursPlayed = 0;
    }

    public void AddPlayTime(int hours) {
        if (hours <= 0) {
            return;
        }

        HoursPlayed += hours;
    }

    public void ChangeRating(int newRating) {
        if (newRating < 1 || newRating > 10) {
            return;
        }

        Rating = newRating;
    }

    public bool IsFinished(int hoursToFinish) {
        if (hoursToFinish <= 0) {
            return false;
        }

        return HoursPlayed >= hoursToFinish;
    }
}
