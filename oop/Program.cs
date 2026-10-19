var ip = new IP(255,255,255,8);

var firstSegment = ip[0];

ip[0] = 192;
ip[1] = 168;
ip[2] = 1;
ip[3] = 1;

Console.WriteLine(ip.Address);
// Console.WriteLine(firstSegment);


var ip2 = new IP("123.123.123.123");

Console.WriteLine(ip2.Address);

