public class IP
{
    private int [] segments = new int[4];

    public int this[int index] 
    {
        get
        {
            return segments[index];
        }


        set
        {
            segments[index] = value;
        } 
    
    
    }
    
    public IP(string IPAddress)
    {
        var segs = IPAddress.Split(".");

        for (int i = 0; i < segs.Length; i++)
        {
            segments[i] =Convert.ToInt32(segs[i]);
        }
    }
    public IP(int seg1,int seg2,int seg3,int seg4)
    {
        segments[0] = seg1;
        segments[1] = seg2;
        segments[2] = seg3;
        segments[3] = seg4;
    }

    public string Address => string.Join(".",segments);

}