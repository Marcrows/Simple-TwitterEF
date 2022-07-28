namespace TwitterEF.Models
{
    public class Tweet
    {
        public string TweetId { get; set; }
        public string TweetContent { get; set; }
        public int Likes { get; set; }
        public int ReTweets { get; set; }
        public int Comments { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}