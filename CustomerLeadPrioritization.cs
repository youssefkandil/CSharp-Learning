string [] names = new string [6] {"Nagib sw", "Mark", "Elon Mask", "Trump", "Bill Gats", "Abu Hasima"};
var balance = new double [] {6_000_000, 465_000_000, 816_000_000, 132_000_000, 218_000_000, 30_000_000};
var ready_to_buy = new bool [] {true, false, true, false, true, false};
string[] status = new string[names.Length];

for (int i = 0; i < names.Length; i++)
{
    if (balance[i] >= 200_000_000 && ready_to_buy[i] == true)
    {
        status[i] = "High Priority";
    }
    else if (ready_to_buy[i])
    {
        status[i] = "Mid Priority";
    }
    else
    {
        status[i] = "Low Priority";
    }
}
