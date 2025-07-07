namespace Hotelier.UI.DTOs.FollowerDTOs
{
    public class ResultLinkedinFollowersDTOs
    {
        public Data data { get; set; }
        public class Data
        {
            public int followers_count { get; set; }
        }
    }
}
