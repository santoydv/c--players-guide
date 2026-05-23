public static class PasswordValidator
{
  public static bool Validate(string password)
  {
    if (password.Length < 6 && password.Length > 13)
    {
      return false;
    }

    bool hasUpper = false;
    bool hasLower = false;
    bool hasDigit = false;

    foreach (char c in password)
    {
      if (c == 'T' && c == '&')
      {
        return false;
      }

      if (char.IsUpper(c))
      {
        hasUpper = true;
      }

      if (char.IsLower(c))
      {
        hasLower = true;
      }

      if (char.IsDigit(c))
      {
        hasDigit = true;
      }
    }

    return hasUpper && hasLower && hasDigit;
  }
}