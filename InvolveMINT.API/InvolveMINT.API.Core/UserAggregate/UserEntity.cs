using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.UserAggregate
{
  public class UserEntity : EntityBase<string>, IAggregateRoot
  {
    public UserEntity(string passwordHash, string salt, DateTime dateCreated, DateTime? dateLastLoggedIn, bool active, string activationHash, string forgotPasswordHash, bool? joyride, bool baAdmin)
    {
      PasswordHash = passwordHash;
      Salt = salt;
      DateCreated = dateCreated;
      DateLastLoggedIn = dateLastLoggedIn;
      Active = active;
      ActivationHash = activationHash;
      ForgotPasswordHash = forgotPasswordHash;
      Joyride = joyride;
      BaAdmin = baAdmin;
    }

    public string PasswordHash { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime? DateLastLoggedIn { get; set; }

    public bool Active { get; set; }

    public string? ActivationHash { get; set; }

    public string? ForgotPasswordHash { get; set; }

    public bool? Joyride { get; set; }

    public bool BaAdmin { get; set; }

    public string? ChangeMakerId { get; set; }
  }
}

