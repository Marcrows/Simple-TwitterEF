namespace TwitterEF.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Bio { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public virtual ICollection<Tweet> ListOfTweets { get; set; }
    }
}