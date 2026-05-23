public class Door
{
  public DoorState State { get; private set; }
  private int _passcode;

  public Door(int passcode)
  {
    State = DoorState.Closed;
    _passcode = passcode;
  }

  public bool ChangePasscode(int currentPasscode, int newPasscode)
  {
    if (currentPasscode != _passcode)
    {
      return false;
    }

    _passcode = newPasscode;
    return true;
  }

  public bool Open()
  {
    if (State == DoorState.Closed)
    {
      State = DoorState.Open;
      return true;
    }
    return false;
  }

  public bool Close()
  {
    if (State == DoorState.Open)
    {
      State = DoorState.Closed;
      return true;
    }
    return false;
  }

  public bool Lock()
  {
    if (State == DoorState.Closed)
    {
      State = DoorState.Locked;
      return true;
    }
    return false;
  }

  public bool Unlock(int currentPasscode)
  {
    if (State == DoorState.Locked && _passcode == currentPasscode)
    {
      State = DoorState.Closed;
      return true;
    }
    return false;
  }
}