using System;

public class SessionState
{
    public string Username { get; private set; } = "Guest User";
    public bool IsLoggedIn { get; private set; } = false;

    public event Action OnChange;

    public void Login(string username)
    {
        Username = username;
        IsLoggedIn = true;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}