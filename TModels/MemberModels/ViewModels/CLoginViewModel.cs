namespace Final10._14.TModels.MemberModels.ViewModels
{
    public class CLoginViewModel
    {
        public string txtAccount { get; set; }
        public string txtPassword { get; set; }
        public override string ToString()
        {
            return $"{nameof(txtAccount)}: {txtAccount}, {nameof(txtPassword)}: {txtPassword}";
        }
    }
}
