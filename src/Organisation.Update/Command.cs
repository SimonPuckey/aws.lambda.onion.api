using System;
namespace Organisation.Update
{
  public class Command //: BaseCommand
  {
    public Guid Id { get; set; }
    public string Name { get; set; }

    public bool IsValid => CheckValidity();

    protected bool CheckValidity()
    {
      Guid guid;
      return Guid.TryParse(Id.ToString(), out guid);
      // return !string.IsNullOrWhiteSpace(Name); 
    }

    // TODO: when intro base command as per J-Simp
    // protected override bool CheckValidity()
    // {
    //     return !string.IsNullOrWhiteSpace(Id)
    //         && !string.IsNullOrWhiteSpace(Name);
    // }
  }
}