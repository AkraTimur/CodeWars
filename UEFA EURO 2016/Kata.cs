using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UEFA_EURO_2016
{
    public class Kata
    {
        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            var wonTeam = "";
            if (scores[0] > scores[1])
            {
                wonTeam = teams[0];
                return $"At match {teams[0]} - {teams[1]}, {wonTeam} won!";
            }
            else if (scores[0] < scores[1])
            {
                wonTeam = teams[1];
                return $"At match {teams[0]} - {teams[1]}, {wonTeam} won!";
            }
            else
            {
                return $"At match {teams[0]} - {teams[1]}, teams played draw.";
            }
        }
    }
}
