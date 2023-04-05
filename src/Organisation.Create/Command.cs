namespace Organisation.Update
{
    //TODO: more meaningful name
    public class Command //: BaseCommand
    {
        public string Name { get; set; }

        public bool IsValid => CheckValidity();

        protected bool CheckValidity()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }

        // TODO: when intro base command as per J-Simp
        // protected override bool CheckValidity()
        // {
        //     return !string.IsNullOrWhiteSpace(Id)
        //         && !string.IsNullOrWhiteSpace(Name);
        // }
    }
}