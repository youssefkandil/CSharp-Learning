public class OOPV2
{
    public static void Run()
    {
        Employee e1 = new Employee();
        // Employee.TAX = 0.03; // This line will cause an error because TAX is a constant and cannot be assigned a value.
        // After changing TAX from const to static, you can now assign a value to it. However, since it's already initialized to 0.03, you don't need to assign it again unless you want to change it.
        Employee.TAX = 0.03;
        e1.DisplayInfo();
    }
}