using System.Text;

namespace Duck_Duck_Goose
{
    public class Kata
    {
        public static string DuckDuckGoose(Player[] players, int goose)
        {
            int flag = 0;
            int count = 1;
            var sb = new StringBuilder();
            while (flag < 1)
            {
                foreach (var player in players)
                {
                    sb.Append(player.Name);
                    if (count == goose)
                    {
                        flag = 1;
                        break;
                    }
                    count++;
                    sb.Clear();
                }
            }
            
            return sb.ToString();
        }
    }
}
//return players[(goose-1) % players.Length].Name;
