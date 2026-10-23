public class Money 
{
    private decimal amount;

    public decimal Amount => amount;
    
    public Money(decimal amount)
    {
        this.amount = Math.Round(amount, 2);
    }

    public static Money operator +(Money m1, Money m2)
    {
        var value = m1.Amount + m2.Amount;
        return new Money(value);
    }

    public static Money operator -(Money m1, Money m2)
    {
        var value = m1.Amount - m2.Amount;
        return new Money(value);
    }
    public static Money operator *(Money m1, Money m2)
    {
        var value = m1.Amount * m2.Amount;
        return new Money(value);
    }

    public static Money operator /(Money m1, Money m2)
    {
        if (m2.Amount == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        var value = m1.Amount / m2.Amount;
        return new Money(value);
    }

    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Amount == m2.Amount;
    }

    public static bool operator !=(Money m1, Money m2)
    {
        return !(m1 == m2);
    } 

    public static bool operator >(Money m1, Money m2)
    {
        return m1.Amount > m2.Amount;
    }

    public static bool operator <(Money m1, Money m2)
    {
        return m1.Amount < m2.Amount;
    }

    public static bool operator <=(Money m1, Money m2)
    {
        return m1.Amount <= m2.Amount;
    }

    public static bool operator >=(Money m1, Money m2)
    {
        return m1.Amount >= m2.Amount;
    }

    public static Money operator ++(Money m1)
    {
        return new Money(m1.Amount + 1);
    }

    public static Money operator --(Money m1)
    {
        return new Money(m1.Amount - 1);
    }

}