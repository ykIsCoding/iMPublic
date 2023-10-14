using InvolveMINT.API.SharedKernel;

namespace InvolveMINT.API.Core.Aggregates.Users
{
  public class User : EntityBase<string>, IAggregateRoot
  {
    private User()
    {
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

